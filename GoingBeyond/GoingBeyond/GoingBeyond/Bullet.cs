using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace GoingBeyond
{
    struct Bullet
    {
        public bool isActive;
        public Vector3 position;
        public Vector3 direction;
        public float speed;

        public void Update(float delta)
        {
            position += direction * speed * GameConstants.BulletSpeedAdjustment * delta;

            if (position.X > GameConstants.PlayfieldSizeX || position.X < -GameConstants.PlayfieldSizeX || position.Y > GameConstants.PlayfieldSizeY || position.Y < -GameConstants.PlayfieldSizeY)
            {
                isActive = false;
            }

        }

    }
}
