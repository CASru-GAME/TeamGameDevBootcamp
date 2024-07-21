using System;

namespace App.Data
{
    public class Atk
    {

        private readonly int _atk;
        /// <summary>
        /// Atk
        /// </summary>
        public int AtkValue { get { return _atk; } }

        //コンストラクタ
        public Atk(int atk)
        {
            // 0より小さい時には例外を発生させる
            if (atk < 0)
            {
                throw new ArgumentException("Atk value cannot be negative");
            }
            this._atk = atk;

        }

        public Atk AddAtk(Atk value)
        {
            return new Atk(this._atk + value.AtkValue);
        }


        public Atk SubtractAtk(Atk value)
        {
            return new Atk(this._atk - value.AtkValue);
        }


        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, Atk : {this._atk}.");
        }
    }
}
