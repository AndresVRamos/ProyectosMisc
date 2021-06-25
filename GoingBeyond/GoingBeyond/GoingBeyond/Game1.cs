using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoingBeyond
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;

        GamePadState lastState = GamePad.GetState(PlayerIndex.One);
        KeyboardState kLastState = Keyboard.GetState();

        //Camera/View information
        Vector3 cameraPosition = new Vector3(0.0f, 0.0f, GameConstants.CameraHeight);
        Matrix projectionMatrix;
        Matrix viewMatrix;

        //Efectos de sonido
        SoundEffect soundEngine;
        SoundEffectInstance soundEngineInstance;
        SoundEffect soundHyperspaceActivation;
        SoundEffect soundExplosion2;
        SoundEffect soundExplosion3;
        SoundEffect soundWeaponsFire;
        SpriteBatch spriteBatch;

        //Nave
        Ship ship = new Ship();

        //Asteroides
        Model asteroidModel;
        Matrix[] asteroidTransforms;
        Asteroid[] asteroidList = new Asteroid[GameConstants.NumAsteroids];
        Random random = new Random();

        //Balas
        Model bulletModel;
        Matrix[] bulletTransforms;
        Bullet[] bulletList = new Bullet[GameConstants.NumBullets];

        //Fondo
        Texture2D stars;

        //Texto
        SpriteFont kootenay;
        int score;
        Vector2 scorePosition = new Vector2(100, 50);

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            projectionMatrix = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45.0f), GraphicsDevice.DisplayMode.AspectRatio, GameConstants.CameraHeight - 1000.0f, GameConstants.CameraHeight + 1000.0f);
            viewMatrix = Matrix.CreateLookAt(cameraPosition, Vector3.Zero, Vector3.Up);
            ResetAsteroids();
            base.Initialize();
        }

        private Matrix[] SetupEffectDefaults(Model myModel)
        {
            Matrix[] absoluteTransfoms = new Matrix[myModel.Bones.Count];
            myModel.CopyAbsoluteBoneTransformsTo(absoluteTransfoms);

            foreach (ModelMesh mesh in myModel.Meshes)
            {
                foreach (BasicEffect effect in mesh.Effects)
                {
                    effect.EnableDefaultLighting();
                    effect.Projection = projectionMatrix;
                    effect.View = viewMatrix;
                }
            }
            return absoluteTransfoms;
        }

        //El aspect ratio determina como escalar la proyección de 2D a 3D
        float aspectRation;

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ship.Model = Content.Load<Model>("Models\\p1_wedge");
            ship.Transforms = SetupEffectDefaults(ship.Model);
            asteroidModel = Content.Load<Model>("Models\\asteroid1");
            asteroidTransforms = SetupEffectDefaults(asteroidModel);
            bulletModel = Content.Load<Model>("Models\\pea_proj");
            bulletTransforms = SetupEffectDefaults(bulletModel);
            stars = Content.Load<Texture2D>("Textures\\B1_stars");
            soundEngine = Content.Load<SoundEffect>("Audio\\Waves\\engine_2");
            soundEngineInstance = soundEngine.CreateInstance();
            soundHyperspaceActivation = Content.Load<SoundEffect>("Audio\\Waves\\hyperspace_activate");
            soundExplosion2 = Content.Load<SoundEffect>("Audio\\Waves\\explosion2");
            soundExplosion3 = Content.Load<SoundEffect>("Audio\\Waves\\explosion3");
            soundWeaponsFire = Content.Load<SoundEffect>("Audio\\Waves\\tx0_fire1");
            kootenay = Content.Load<SpriteFont>("Fonts\\Kootenay");
            aspectRation = graphics.GraphicsDevice.Viewport.AspectRatio;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        /// 

        protected override void Update(GameTime gameTime)
        {
            float timeDelta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            //Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();
            //Get some input.
            UpdateInput();
            //Add velocity to the current position.
            ship.Position += ship.Velocity;
            //Bleedoffvelocityovertime.
            ship.Velocity *= 0.95f;

            for (int i = 0; i < GameConstants.NumAsteroids; i++)
            {
                asteroidList[i].Update(timeDelta);
            }

            for (int i = 0; i < GameConstants.NumBullets; i++)
            {
                if (bulletList[i].isActive)
                {
                    bulletList[i].Update(timeDelta);
                }
            }

            //bullet-asteroid collision check
            for (int i = 0; i < asteroidList.Length; i++)
            {
                if (asteroidList[i].isActive)
                {
                    BoundingSphere asteroidSphere = new BoundingSphere(asteroidList[i].position, asteroidModel.Meshes[0].BoundingSphere.Radius * GameConstants.AsteroidBoundingSphereScale);
                    for (int j = 0; j < bulletList.Length; j++)
                    {
                        if (bulletList[j].isActive)
                        {
                            BoundingSphere bulletSphere = new BoundingSphere(bulletList[j].position, bulletModel.Meshes[0].BoundingSphere.Radius);
                            if (asteroidSphere.Intersects(bulletSphere))
                            {
                                soundExplosion2.Play();
                                score += GameConstants.KillBonus;
                                asteroidList[i].isActive = false;
                                bulletList[j].isActive = false;
                                break;
                            }
                        }
                    }
                }
            }

            if (ship.isActive)
            {
                //ship-asteroid collision check
                BoundingSphere shipSphere = new BoundingSphere(ship.Position, ship.Model.Meshes[0].BoundingSphere.Radius * GameConstants.ShipBoundingSphereScale);

                for (int i = 0; i < asteroidList.Length; i++)
                {
                    BoundingSphere b = new BoundingSphere(asteroidList[i].position, asteroidModel.Meshes[0].BoundingSphere.Radius * GameConstants.AsteroidBoundingSphereScale);
                    if (asteroidList[i].isActive)
                    {
                        if (b.Intersects(shipSphere))
                        {
                            //explotar la nave
                            soundExplosion3.Play();
                            score -= GameConstants.DeathPenalty;
                            asteroidList[i].isActive = false;
                            ship.isActive = false;
                            break;
                        } 
                    }
                }
                
            }

            base.Update(gameTime);
        }

        protected void UpdateInput()
        {
            //Estado de Gamepad
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);
            KeyboardState teclado = Keyboard.GetState();
            if (true)
            {
                ship.Update(currentState, teclado);

                //Que suene el sonido del motor solo cuando el motor está encendido.
                if (currentState.Triggers.Right > 0 || Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.D))
                {
                    if (soundEngineInstance.State == SoundState.Stopped)
                    {
                        soundEngineInstance.Volume = 0.75f;
                        soundEngineInstance.IsLooped = true;
                        soundEngineInstance.Play();
                    }
                    else
                        soundEngineInstance.Resume();
                }
                else if (currentState.Triggers.Right == 0)
                {
                    if (soundEngineInstance.State == SoundState.Playing)
                    {
                        soundEngineInstance.Pause();
                    }
                }

                //Si nos perdemos, pulsamos A o Enter para volver al centro
                if (currentState.Buttons.A == ButtonState.Pressed || teclado.IsKeyDown(Keys.Enter) && kLastState.IsKeyUp(Keys.Enter))
                {
                    ship.isActive = true;
                    ship.Position = Vector3.Zero;
                    ship.Velocity = Vector3.Zero;
                    ship.Rotation = 0.0f;
                    soundHyperspaceActivation.Play();
                    score -= GameConstants.WarpPenalty;
                }

                //Estamos disparando?
                if (ship.isActive && teclado.IsKeyDown(Keys.Space) && kLastState.IsKeyUp(Keys.Space))
                {
                    //Añadimos otra bala. Buscamos un espacio de bala no usada y lo usamod
                    //Si todos los espacios de bala estan usados, se ignora el input del jugador
                    for (int i = 0; i < GameConstants.NumBullets; i++)
                    {
                        if (!bulletList[i].isActive)
                        {
                            bulletList[i].direction = ship.RotationMatrix.Forward;
                            bulletList[i].speed = GameConstants.BulletSpeedAdjustment;
                            bulletList[i].position = ship.Position + (200 * bulletList[i].direction);
                            bulletList[i].isActive = true;
                            soundWeaponsFire.Play();
                            score -= GameConstants.ShotPenalty;
                            break;
                        }
                    }
                }
            }
            lastState = currentState;
            kLastState = teclado;
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.Opaque);
            spriteBatch.Draw(stars, new Rectangle(0, 0, 800, 600), Color.White);
            spriteBatch.End();

            //// TODO: Add your drawing code here
            ////Copiar cualquier transformación padre
            //Matrix[] transforms = new Matrix[myModel.Bones.Count];
            //myModel.CopyAbsoluteBoneTransformsTo(transforms);

            ////Dibujar el model. Un modelo puede contener múltiples mallas
            ////así que lo ciclaremos
            //foreach (ModelMesh mesh in myModel.Meshes)
            //{
            //    //Aquí es donde se ajusta la orientación de la malla, así como 
            //    //de nuestra camara y la proyección

            //    foreach (BasicEffect effect in mesh.Effects)
            //    {
            //        effect.EnableDefaultLighting();
            //        effect.World = transforms[mesh.ParentBone.Index] * Matrix.CreateRotationY(modelRotation) * Matrix.CreateTranslation(modelPosition);
            //        effect.View = Matrix.CreateLookAt(cameraPosition, Vector3.Zero, Vector3.Up);
            //        effect.Projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45.0f), aspectRation, 1.0f, 10000.0f);
            //    }
            //    mesh.Draw();
            //}

            Matrix shipTransformMatrix = ship.RotationMatrix * Matrix.CreateTranslation(ship.Position);
            if (ship.isActive)
            {
                DrawModel(ship.Model, shipTransformMatrix, ship.Transforms);

            }
            for (int i = 0; i < GameConstants.NumAsteroids; i++)
            {
                if (asteroidList[i].isActive)
                {
                    Matrix asteroidTransform = Matrix.CreateTranslation(asteroidList[i].position);
                    DrawModel(asteroidModel, asteroidTransform, asteroidTransforms); 
                }
            }
            for (int i = 0; i < GameConstants.NumBullets; i++)
            {
                if (bulletList[i].isActive)
                {
                    Matrix bulletTransform = Matrix.CreateTranslation(bulletList[i].position);
                    DrawModel(bulletModel, bulletTransform, bulletTransforms);
                }
            }

            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.Opaque);
            spriteBatch.DrawString(kootenay, "Score: " + score, scorePosition, Color.LightGreen);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public static void DrawModel(Model model, Matrix modelTransform, Matrix[] absoluteBoneTransforms)
        {
            //Dibujar el modelo, un modelo puede tener varios meshes, asi que loopeamos
            foreach (ModelMesh mesh in model.Meshes)
            {
                //Aquí se establece la orientación del mesh
                foreach (BasicEffect effect in mesh.Effects)
                {
                    effect.World = absoluteBoneTransforms[mesh.ParentBone.Index] * modelTransform;
                }
                //Dibujar el mesh, se usarán los efectos de arriba.
                mesh.Draw();
            }
        }

        private void ResetAsteroids()
        {
            float xStart;
            float yStart;

            for (int i = 0; i < GameConstants.NumAsteroids; i++)
            {
                asteroidList[i].isActive = true;
                if (random.Next(2) == 0)
                {
                    xStart = (float)-GameConstants.PlayfieldSizeX;
                }
                else
                {
                    xStart = (float)GameConstants.PlayfieldSizeX;
                }
                yStart = (float)random.NextDouble() * GameConstants.PlayfieldSizeY;

                //asteroidList[i].position = Vector3.Zero;
                asteroidList[i].position = new Vector3(xStart, yStart, 0.0f);
                double angle = random.NextDouble() * 2 * Math.PI;
                asteroidList[i].direction.X = -(float)Math.Sin(angle);
                asteroidList[i].direction.Y = -(float)Math.Cos(angle);
                asteroidList[i].speed = GameConstants.AsteroidMinSpeed + (float)random.NextDouble() * GameConstants.AsteroidMaxSpeed;
            }
        }
    }
}
