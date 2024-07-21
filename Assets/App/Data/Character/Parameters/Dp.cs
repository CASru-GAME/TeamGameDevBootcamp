using System;

namespace Dpp.Data
{
    public class Dp
    {

        private readonly int _def;
        /// <summary>
        /// Def
        /// </summary>
        public int Def { get { return _def; } }

        private readonly int _mde;
        /// <summary>
        /// Mde
        /// </summary>
        public int Mde { get { return _mde; } }


        //引数が2個のコンストラクタ
        private Dp(int def, int mde)
        {
            // 0より小さい時には例外を発生させる
            if(def < 0 && mde < 0)
            {
                throw new ArgumentException("Def and Mde value cannot be negative");
            }
            else if (def < 0)
            {
                throw new ArgumentException("Def value cannot be negative");
            }
            else if (mde < 0)
            {
                throw new ArgumentException("Mde value cannot be negative");
            }
            this._def = def;
            this._mde = mde;
        }

        //引数が１個の場合、this(Def, Mde)の部分で上のコンストラクタを使用し、
        //同じ値をDefとMDpに代入している。
        public Dp(int value) : this(value, value) { }

        public Dp AddDef(Dp value)
        {
            return new Dp(this._def + value.Def, this._mde);
        }

        public Dp AddMde(Dp value)
        {
            return new Dp(this._def, this._mde + value.Mde);
        }

        public Dp SubtractDef(Dp value)
        {
            return new Dp(this._def - value.Def, this._mde);
        }

        public Dp SubtractMde(Dp value)
        {
            return new Dp(this._def, this._mde - value.Mde);
        }

        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, Def : {this._def}, Mde : {this._mde}.");
        }
    }
}
