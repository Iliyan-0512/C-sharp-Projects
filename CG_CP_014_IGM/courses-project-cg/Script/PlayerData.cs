using Godot;
using System;
public partial class PlayerData : Node
{
	private int _health = 100;
	private int _coins = 0;
	private int _gems = 0;

	public event Action<int> HealthChanged;
	public event Action<int> CoinsChanged;
	public event Action<int> GemsChanged;

	public int Health
	{
		get => _health;
		set
		{
			_health = Mathf.Max(0, value);
			GD.Print("Player HP = ", _health);
			HealthChanged?.Invoke(_health);
		}
	}

	public int Coins
	{
		get => _coins;
		set
		{
			_coins = Mathf.Max(0, value);
			GD.Print("Player Coins = ", _coins);
			CoinsChanged?.Invoke(_coins);
		}
	}

	public int Gems
	{
		get => _gems;
		set
		{
			_gems = Mathf.Max(0, value);
			GD.Print("Player Gems = ", _gems);
			GemsChanged?.Invoke(_gems);
		}
	}

	public void ResetForNewRun()
	{
		Health = 100;
		Coins = 0;
		Gems = 0;
	}

	public int Damage = 10;
}
