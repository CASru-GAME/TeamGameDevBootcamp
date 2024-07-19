using System;

public class Hp
{
    private readonly int _maxHp;
    public int maxHp { get { return _maxHp; } }
    private readonly int _currentHp;
    public int currentHp { get { return _currentHp; } }

    public Hp(int maxHpValue, int currentHpValue)
    {
		
        // 0より小さい時には例外を発生させる
        if (currentHpValue < 0) {
            throw new ArgumentException("Value cannot be negative");
        }
        else if (currentHpValue > this._maxHp) {
            throw new ArgumentException("Value cannot over maxHp");
        }
        this._currentHp = currentHpValue;
        this._maxHp = maxHpValue;
    }

    public Hp(int maxHpValue) : this(maxHpValue, maxHpValue){}

    public Hp Add(Hp addedHp)
    {
        if (this._currentHp + addedHp.maxHp > this._maxHp) {
            return new Hp(this._maxHp, this._maxHp);
        }
        else {
            return new Hp(this._maxHp, this._maxHp + addedHp.maxHp);
        }
    }

    public Hp Substract(Hp substructedHp)
    {
        if (this._currentHp - substructedHp.maxHp < 0) {
            return new Hp(this._maxHp, 0);
        }
        else {
            return new Hp(this._maxHp, this._currentHp - substructedHp.maxHp);
        }
    }
}
