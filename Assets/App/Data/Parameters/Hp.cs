using System;

namespace App.Data
{
    /**  
   <summary>
   Hpの値オブジェクト
   </summary>
   */
    public class Hp
    {
        /// <summary>
        /// 最大Hp
        /// </summary>
        private readonly int _maxHp;
        public int MaxHp { get { return _maxHp; } }
        /// <summary>
        /// 現在のHp
        /// </summary>
        private readonly int _currentHp;
        public int CurrentHp { get { return _currentHp; } }

        //引数が２個の場合のコンストラクタ
        private Hp(int maxHp, int currentHp)
        {

            // 0より小さい時には例外を発生させる
            if (currentHp < 0)
            {
                throw new ArgumentException("Value cannot be negative");
            }
            // maxHpを超える時には例外を発生させる
            else if (currentHp > maxHp)
            {
                throw new ArgumentException("Value cannot over maxHp");
            }
            this._currentHp = currentHp;
            this._maxHp = maxHp;
        }

        //引数が１個の場合、this(maxHpValue, maxHpValue)の部分で上のコンストラクタを使用し、
        //同じ値をcurrentHpとmaxHpに代入している。
        public Hp(int maxHpValue) : this(maxHpValue, maxHpValue) { }

        public Hp AddCurrentHp(Hp value)
        {
            if (this._currentHp + value.CurrentHp > this._maxHp)
            {
                return new Hp(this._maxHp, this._maxHp);
            }
            else
            {
                return new Hp(this._maxHp, this._currentHp + value.CurrentHp);
            }
        }

        public Hp AddMaxHp(Hp value)
        {
            return new Hp(this._maxHp + value.CurrentHp, this._currentHp);
        }

        public Hp SubstractCurrentHp(Hp value)
        {
            if (this._currentHp - value.CurrentHp < 0)
            {
                return new Hp(this._maxHp, 0);
            }
            else
            {
                return new Hp(this._maxHp, this._currentHp - value.CurrentHp);
            }
        }

        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, MaxHp : {this._maxHp}, CurrentHp : {this._currentHp}");
        }
    }
}
