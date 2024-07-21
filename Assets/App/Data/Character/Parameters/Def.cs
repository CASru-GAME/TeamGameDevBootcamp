using System;

namespace App.Data
{
    public class Def
    {

        private readonly int _def;
        /// <summary>
        /// Def
        /// </summary>
        public int DefValue { get { return _def; } }

        //コンストラクタ
        public Def(int def)
        {
            // 0より小さい時には例外を発生させる
            if (def < 0)
            {
                throw new ArgumentException("Def value cannot be negative");
            }
            this._def = def;

        }

        public Def AddDef(Def value)
        {
            return new Def(this._def + value.DefValue);
        }


        public Def SubtractMat(Def value)
        {
            return new Def(this._def - value.DefValue);
        }


        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, Def : {this._def}.");
        }
    }
}
