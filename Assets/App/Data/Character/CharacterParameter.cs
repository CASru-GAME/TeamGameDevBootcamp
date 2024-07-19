using UnityEngine;

public abstract class CharacterParameter
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public int MaxHp { get; set; }
    [field: SerializeField] public int CurrentHp { get; set; }
    [field: SerializeField] public int MaxMp { get; set; }
    [field: SerializeField] public int CurrentMp { get; set; }
    [field: SerializeField] public int Attack { get; set; }
    [field: SerializeField] public int MagicAttack { get; set; }
    [field: SerializeField] public int Defense { get; set; }
    [field: SerializeField] public int MagicDefense { get; set; }

    public void ChangeMaxHp(int value)
    {
        MaxHp += value;
    }
    public void ChangeCurrentHp(int value)
    {
        if (CurrentHp + value > MaxHp)
        {
            CurrentHp = MaxHp;
            return;
        }
        CurrentHp += value;
    }
    public void ChangeMaxMp(int value)
    {
        MaxMp += value;
    }
    public void ChangeCurrentMp(int value)
    {
        if (CurrentMp + value > MaxMp)
        {
            CurrentMp = MaxMp;
            return;
        }
        CurrentMp += value;
    }
    public void ChangeAttack(int value)
    {
        Attack += value;
    }
    public void ChangeMagicAttack(int value)
    {
        MagicAttack += value;
    }
    public void ChangeDefense(int value)
    {
        Defense += value;
    }
    public void ChangeMagicDefense(int value)
    {
        MagicDefense += value;
    }
}