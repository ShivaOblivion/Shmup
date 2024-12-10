using Godot;
using System;

// Author : William Soukai

namespace Com.IsartDigital.ProjectName {
	
	public partial class CircularMovement : Node2D
	{  [Export] private float radius = 100.0f; // Rayon du cercle
       [Export] private float speed = 6.0f;    // Vitesse angulaire (radians par seconde)
       [Export] private Vector2 starPos;        // Centre du cercle

        private float angle = 0.0f; // Angle actuel

        public override void _Ready()
        {
            starPos = Position;

        }

        public override void _Process(double delta)
        {
            GD.Print(Position); // Débogage du centre
            angle += speed * (float)delta; // Mise à jour de l'angle
            radius += speed * (float)delta * 5f;
            float x = starPos.X + radius * Mathf.Cos(angle);
            float y = starPos.Y + radius * Mathf.Sin(angle);
            Position = new Vector2(x, y); 
        }
    }

    
}

