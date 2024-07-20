using System;

namespace App.Data
{
     /**  
    <summary>
    Mpの値オブジェクト
    </summary>
    */
    public class Mp
    {
        private readonly int _maxMp;
        /// <summary>
        /// 最大Mp
        /// </summary>
        public int MaxMp { get { return _maxMp; } }
        /// <summary>
        /// 現在のMp
        /// </summary>
        private readonly int _currentMp;
        public int CurrentMp { get { return _currentMp; } }

        //引数が２個の場合のコンストラクタ
        private Mp(int maxMp, int currentMp)
        {

            // 0より小さい時には例外を発生させる
            if (currentMp < 0)
            {
                throw new ArgumentException("Value cannot be negative");
            }
            // maxMpを超える時には例外を発生させる
            else if (currentMp > this._maxMp)
            {
                throw new ArgumentException("Value cannot over maxMp");
            }
            this._currentMp = currentMp;
            this._maxMp = maxMp;
        }

        //引数が１個の場合、this(maxMpValue, maxMpValue)の部分で上のコンストラクタを使用し、
        //同じ値をcurrentMpとmaxMpに代入している。
        public Mp(int maxMpValue) : this(maxMpValue, maxMpValue) { }

        public Mp AddCurrentMp(readonly Mp value)
        {
            if (this._currentMp + value.CurrentMp > this._maxMp)
            {
                return new Mp(this._maxMp, this._maxMp);
            }
            else
            {
                return new Mp(this._maxMp, this._currentMp + value.CurrentMp);
            }
        }

        public Mp AddMaxMp(Mp value)
        {
            return new Mp(this._maxMp + value.CurrentMp, this._currentMp);
        }

        public Mp SubstractCurrentMp(Mp value)
        {
            if (this._currentMp - value.CurrentMp < 0)
            {
                return new Mp(this._maxMp, 0);
            }
            else
            {
                return new Mp(this._maxMp, this._currentMp - value.CurrentMp);
            }
        }
    }
}
