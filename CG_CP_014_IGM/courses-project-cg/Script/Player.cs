using Godot;
using System;

public partial class Player : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;

	private bool isAttacking = false;
	private float attackTimer = 0f;
	private float attackDuration = 0.7f;

	private bool isDead = false;

	private BoarEnemy currentEnemy;

	public override void _PhysicsProcess(double delta)
	{
		// 1) Ако играчът е мъртъв – не приема вход, не се движи
		if (isDead)
		{
			Velocity = Vector2.Zero;
			MoveAndSlide();
			return;
		}

		Vector2 velocity = Velocity;
		AnimatedSprite2D sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

		// 2) Ако атакува – изчакваме да свърши анимацията
		if (isAttacking)
		{
			attackTimer -= (float)delta;
			if (attackTimer <= 0f)
			{
				isAttacking = false;
			}
			else
			{
				Velocity = Vector2.Zero;
				MoveAndSlide();
				return;
			}
		}

		// 3) Гравитация
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)delta;
		}

		// 4) Скок
		if (Input.IsActionJustPressed("ui_up") && IsOnFloor())
		{
			velocity.Y = JumpVelocity;
		}

		// 5) Хоризонтално движение
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");

		if (direction.X < 0)
			sprite.FlipH = true;
		else if (direction.X > 0)
			sprite.FlipH = false;

		if (!IsOnFloor())
			sprite.Animation = "Jump";
		else if (direction != Vector2.Zero)
			sprite.Animation = "Run";
		else
			sprite.Animation = "Idle";

		sprite.Play();

		if (direction != Vector2.Zero)
			velocity.X = direction.X * Speed;
		else
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);

		Velocity = velocity;
		MoveAndSlide();

		// 6) Атака
		if (Input.IsActionJustPressed("ui_select"))
		{
			GD.Print("Player attack, currentEnemy = ", currentEnemy);
			sprite.Animation = "Attack";
			sprite.Play();
			isAttacking = true;
			attackTimer = attackDuration;

			var playerData = (PlayerData)GetNode("/root/PlayerData");
			if (currentEnemy != null)
			{
				currentEnemy.TakeDamage(playerData.Damage);
			}
		}
	}

	public void SetEnemy(BoarEnemy enemy)
	{
		currentEnemy = enemy;
	}

	public void RemoveEnemy()
	{
		currentEnemy = null;
	}

	public void Die()
{
	if (isDead)
		return;

	isDead = true;

	var sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	sprite.Animation = "Dead";
	sprite.Play();

	Velocity = Vector2.Zero;
	MoveAndSlide();

	GD.Print("PLAYER DIED (Die() called)");
}

}
