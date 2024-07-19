using System;

public class Mp
{
    private readonly int _maxMp;
    public int maxMp { get { return _maxMp; } }
    private readonly int _currentMp;
    public int currentMp { get { return _currentMp; } }

    //引数が２個の場合のコンストラクタ
    public Mp(int maxMpValue, int currentMpValue)
    {
		
        // 0より小さい時には例外を発生させる
        if (currentMpValue < 0) {
            throw new ArgumentException("Value cannot be negative");
        }
        // maxMpを超える時には例外を発生させる
        else if (currentMpValue > this._maxMp) {
            throw new ArgumentException("Value cannot over maxMp");
        }
        this._currentMp = currentMpValue;
        this._maxMp = maxMpValue;
    }

    //引数が１個の場合、this(maxMpValue, maxMpValue)の部分で上のコンストラクタを使用し、
    //同じ値をcurrentMpとmaxMpに代入している。
    public Mp(int maxMpValue) : this(maxMpValue, maxMpValue){}

    public Mp AddCurrentMp(Mp addedMp)
    {
        if (this._currentMp + addedMp.maxMp > this._maxMp) {
            return new Mp(this._maxMp);
        }
        else {
            return new Mp(this._maxMp, this._currentMp + addedMp.maxMp);
        }
    }

    public Mp AddMaxMp(Mp addedMp)
    {
        return new Mp(this._maxMp + addedMp.maxMp);
    }

    public Mp Substract(Mp substructedMp)
    {
        if (this._currentMp - substructedMp.maxMp < 0) {
            return new Mp(this._maxMp, 0);
        }
        else {
            return new Mp(this._maxMp, this._currentMp - substructedMp.maxMp);
        }
    }
}
