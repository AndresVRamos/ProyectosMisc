using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GoingBeyond
{
    class Ship
    {
        public Model Model;
        public Matrix[] Transforms;

        //Posición del modelo en el mundo
        public Vector3 Position = Vector3.Zero;

        //Velocidad del modelo, aplicado cada frame a la posición del modelo
        public Vector3 Velocity = Vector3.Zero;

        //Amplifica la velocidad del input del control
        private const float VelocityScale = 5.0f;

        //Ver si estamos vivos
        public bool isActive = true;

        public Matrix RotationMatrix = Matrix.CreateRotationX(MathHelper.PiOver2);
        private float rotation;
        public float Rotation 
        {
            get { return rotation; }
            set
            {
                float newVal = value;
                while (newVal >= MathHelper.TwoPi)
                {
                    newVal -= MathHelper.TwoPi;
                }
                while (newVal < 0)
                {
                    newVal += MathHelper.TwoPi;
                }

                if (rotation != value)
                {
                    rotation = value;
                    RotationMatrix = Matrix.CreateRotationX(MathHelper.PiOver2) * Matrix.CreateRotationZ(rotation);
                }
            }
        }

        public void Update (GamePadState controllerState, KeyboardState teclado)
        {
            //Rotar el modelo usando el thumbstick izquierdo, y escalarlo hacia abajo
            Rotation -= controllerState.ThumbSticks.Left.X * 0.10f;
            if (teclado.IsKeyDown(Keys.A))
            {
                Rotation += 0.10f;
            }
            else if (teclado.IsKeyDown(Keys.D))
            {
                Rotation -= 0.10f;
            }

            //Finalmente, añadir este vector a nuestra velocidad.
            Velocity += RotationMatrix.Forward * 1.0f * controllerState.Triggers.Right;

            if (teclado.IsKeyDown(Keys.W))
            {
                Velocity += RotationMatrix.Forward * 10.0f;
            }
            else if (teclado.IsKeyDown(Keys.S))
            {
                Velocity += RotationMatrix.Forward * -10.0f;
            }
            //Velocity += RotationMatrix.Forward * VelocityScale * controllerState.Triggers.Right;
            //Velocity += RotationMatrix.Forward * VelocityScale * 0.0f;
        }

    }
}
