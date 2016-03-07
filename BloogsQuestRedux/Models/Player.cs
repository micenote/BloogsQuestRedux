﻿using Microsoft.Xna.Framework;

namespace BloogsQuestRedux.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string TextureFilename { get; set; }
        public Sprite Sprite { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle BoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)Position.X + 10,
                    (int)Position.Y + 10,
                    30,
                    30);
            }
        }

        public Player(Vector2 initialPosition)
        {
            Position = initialPosition;
            TextureFilename = "player";
            Sprite = new Sprite();
        }
    }
}