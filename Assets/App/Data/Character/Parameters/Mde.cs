using System;

namespace App.Data
{
    public class Mde
    {

        private readonly int _mde;
        /// <summary>
        /// Mde
        /// </summary>
        public int MdeValue { get { return _mde; } }

        //コンストラクタ
        public Mde(int mde)
        {
            // 0より小さい時には例外を発生させる
            if (mde < 0)
            {
                throw new ArgumentException("Mde value cannot be negative");
            }
            this._mde = mde;

        }

        public Mde AddMde(Mde value)
        {
            return new Mde(this._mde + value.MdeValue);
        }


        public Mde SubtractMat(Mde value)
        {
            return new Mde(this._mde - value.MdeValue);
        }


        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, Mde : {this._mde}.");
        }
    }
}
