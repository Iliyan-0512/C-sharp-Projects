using Godot;
using System;

public partial class BoarEnemy : CharacterBody2D
{
	public int Health = 10;
	public int Damage = 30;
	private AnimatedSprite2D sprite;

	[Export] public float Speed = 80f;

	public float AttackCooldown = 1.0f;
	private float _attackTimer = 0f;
	private bool _playerInRange = false;
	private Player _playerTarget;

	private int _direction = 1; // 1 = надясно, -1 = наляво

	public override void _Ready()
	{
		sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	public override void _PhysicsProcess(double delta)
	{
		// движение
		Vector2 velocity = Velocity;
		velocity.X = _direction * Speed;
		Velocity = velocity;

		// плъзгане + сблъсъци
		MoveAndSlide();

		// обръщане при удар в стена
		int collisionCount = GetSlideCollisionCount();
for (int i = 0; i < collisionCount; i++)
{
	var collision = GetSlideCollision(i);
	Vector2 normal = collision.GetNormal();   // <-- важното

	if (Mathf.Abs(normal.X) > 0.9f)
	{
		_direction *= -1;
		break;
	}
}


		// обръщане на спрайта
		sprite.FlipH = _direction < 0;

		// атака, ако играчът е в зоната
		if (_playerInRange && _playerTarget != null)
		{
			 
			_attackTimer -= (float)delta;
			if (_attackTimer <= 0f)
			{
				GD.Print("Enemy ATTACK TRIGGER");
				AttackPlayer();
				_attackTimer = AttackCooldown;
			}
		}
	}

	// щета от играча
	public void TakeDamage(int amount)
	{
		GD.Print("Enemy got hit for ", amount);
		Health -= amount;
		if (Health <= 0)
		{
			Die();
		}
		else
		{
			sprite.Animation = "Hit";
			sprite.Play();
		}
	}

	private void Die()
	{
		sprite.Animation = "Hit";
		sprite.Play();
		GetTree().CreateTimer(0.25f).Timeout += () => CallDeferred("queue_free");
	}

private void AttackPlayer()
{
	GD.Print("Player IN RANGE, timer = ", _attackTimer);

	var playerData = (PlayerData)GetNode("/root/PlayerData");
	playerData.Health -= Damage;

	GD.Print("Enemy hit player for ", Damage, " | Player HP = ", playerData.Health);

	if (playerData.Health <= 0)
	{
		GetTree().ChangeSceneToFile("res://Scenes/GameOver.tscn");
	}
}



private void _on_area_2d_body_entered(Node2D body)
{
	GD.Print("ENTER: ", body, " type = ", body.GetType().Name);
	if (body is Player player)
	{
		GD.Print("ENTER is Player -> set in range TRUE");
		_playerInRange = true;
		_playerTarget = player;
		player.SetEnemy(this);
	}
}

private void _on_area_2d_body_exited(Node2D body)
{
	GD.Print("EXIT: ", body, " type = ", body.GetType().Name);
	if (body is Player player)
	{
		GD.Print("EXIT is Player -> set in range FALSE");
		_playerInRange = false;
		_playerTarget = null;
		player.RemoveEnemy();
	}

}
}
