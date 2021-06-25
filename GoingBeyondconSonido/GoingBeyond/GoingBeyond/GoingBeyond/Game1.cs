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
        SpriteBatch spriteBatch;

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

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        /// 

        // Colocar el Modelo 3D para dibujar
        Model myModel;

        //Efectos de sonido
        SoundEffect soundEngine;
        SoundEffectInstance soundEngineInstance;
        SoundEffect soundHyperspaceActivation;

        //El aspect ratio determina como escalar la proyección de 2D a 3D
        float aspectRation;

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            myModel = Content.Load<Model>("Models\\p1_wedge");
            soundEngine = Content.Load<SoundEffect>("Audio\\Waves\\engine_2");
            soundEngineInstance = soundEngine.CreateInstance();
            soundHyperspaceActivation = Content.Load<SoundEffect>("Audio\\Waves\\hyperspace_activate");
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

        Vector3 modelVelocity = Vector3.Zero;
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
                || Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            //Utilizar el metodo para revisar actualizaciones (que ha pasado)
            UpdateInput();

            //Agregar velocidad a la posición actual
            modelPosition += modelVelocity;

            //modelRotation += (float)gameTime.ElapsedGameTime.TotalMilliseconds * MathHelper.ToRadians(0.1f);

            //Perdida de velocidad comforme pasa el tiempo
            modelVelocity *= 0.95f;

            base.Update(gameTime);
        }

        protected void UpdateInput()
        {
            //Leer el estado del gamepad
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);
            KeyboardState currentKeyState = Keyboard.GetState();

            if (currentKeyState.IsKeyDown(Keys.A))
                modelRotation += 0.10f;
            else if (currentKeyState.IsKeyDown(Keys.D))
                modelRotation -= 0.10f;
            else 
                //Rotar el modelo usando la palanca izquierda y retroescalar
                modelRotation -= currentState.ThumbSticks.Left.X * 0.10f;

                //Crear alguna velocidad si se está presionando el disparador derecho o la tecla W
                Vector3 modelVelocityAdd = Vector3.Zero;

                //Encontrar en que dirección debemos dirigirnos utilizando rotación
                modelVelocityAdd.X = -(float)Math.Sin(modelRotation);
                modelVelocityAdd.Z = -(float)Math.Cos(modelRotation);
            if (currentKeyState.IsKeyDown(Keys.W))
                modelVelocityAdd *= 8;
            else if (currentKeyState.IsKeyDown(Keys.S))
                modelVelocityAdd *= -8;
            else
                //Ahora vamos a escalar nuestra dirección dependiendo de que tan fuerte estemos precionando el trigger
                modelVelocityAdd *= currentState.Triggers.Right;

            //Finalmente Vamos a agragar este vector a nuestra velocidad
            modelVelocity += modelVelocityAdd;

            GamePad.SetVibration(PlayerIndex.One, currentState.Triggers.Right, currentState.Triggers.Right);

            if (currentState.Triggers.Right > 0 
                || currentKeyState.IsKeyDown(Keys.D) 
                || currentKeyState.IsKeyDown(Keys.A) 
                || currentKeyState.IsKeyDown(Keys.W) 
                || currentKeyState.IsKeyDown(Keys.S))
            {
                if (soundEngineInstance.State == SoundState.Stopped)
                {
                    soundEngineInstance.Volume = 0.75f;
                    soundEngineInstance.IsLooped = true;
                    soundEngineInstance.Play();
                }
                else
                {
                    soundEngineInstance.Resume();
                }

            }
            else if (currentState.Triggers.Right == 0 
                || currentKeyState.IsKeyUp(Keys.D) 
                || currentKeyState.IsKeyUp(Keys.A) 
                || currentKeyState.IsKeyUp(Keys.W) 
                || currentKeyState.IsKeyUp(Keys.S))
            {
                if (soundEngineInstance.State == SoundState.Playing)
                {
                    soundEngineInstance.Pause();
                }
            }

            //En caso de perderse la nave, presionando A (gamepad) o Enter (teclado) creamos un portal hacia el centro 
            if (currentState.Buttons.A ==ButtonState.Pressed || currentKeyState.IsKeyDown(Keys.Enter))
            {
                modelPosition = Vector3.Zero;
                modelVelocity = Vector3.Zero;
                modelRotation = 0.0f;
                soundHyperspaceActivation.Play();
            }


        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        /// 
        //Ajusta la posición del modelo en el espacio del mundo, y ajusta la rotación
        Vector3 modelPosition = Vector3.Zero;
        float modelRotation = 0.0f;

        //Ajusta la posición de la camara en el espacio del mundo,
        // para nuestra matriz de visualización
        Vector3 cameraPosition = new Vector3(0.0f, 50.0f, 5000.0f);
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            //Copiar cualquier transformación padre
            Matrix[] transforms = new Matrix[myModel.Bones.Count];
            myModel.CopyAbsoluteBoneTransformsTo(transforms);

            //Dibujar el model. Un modelo puede contener múltiples mallas
            //así que lo ciclaremos
            foreach (ModelMesh mesh in myModel.Meshes)
            {
                //Aquí es donde se ajusta la orientación de la malla, así como 
                //de nuestra camara y la proyección

                foreach (BasicEffect effect in mesh.Effects)
                {
                    effect.EnableDefaultLighting();
                    effect.World = transforms[mesh.ParentBone.Index] * Matrix.CreateRotationY(modelRotation) * Matrix.CreateTranslation(modelPosition);
                    effect.View = Matrix.CreateLookAt(cameraPosition, Vector3.Zero, Vector3.Up);
                    effect.Projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45.0f), aspectRation, 1.0f, 10000.0f);
                }
                mesh.Draw();
            }


            base.Draw(gameTime);
        }
    }
}
