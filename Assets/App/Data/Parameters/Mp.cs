using System;

public class Mp
{
    private readonly int _maxMp;
    public int maxMp { get { return _maxMp; } }
    private readonly int _currentMp;
    public int currentMp { get { return _currentMp; } }

    public Mp(int maxMpValue, int currentMpValue) {
		
        // 0より小さい時には例外を発生させる
        if (currentMpValue < 0) {
            throw new ArgumentException("Value cannot be negative");
        }
        else if (currentMpValue > this._maxMp) {
            throw new ArgumentException("Value cannot over maxMp");
        }
        this._currentMp = currentMpValue;
        this._maxMp = maxMpValue;
    }

    public Mp Add(int addedMp) {
        if (this._currentMp + addedMp > this._maxMp) {
            return new Mp(this._maxMp, this._maxMp);
        }
        else {
            return new Mp(this._maxMp, this._maxMp + addedMp);
        }
    }

    public Mp Substract(int substructedMp) {
        if (this._currentMp - substructedMp < 0) {
            return new Mp(this._maxMp, 0);
        }
        else {
            return new Mp(this._maxMp, this._currentMp - substructedMp);
        }
    }
}
