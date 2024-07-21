using System;

namespace App.Data
{
    public class Ap
    {

        private readonly int _atk;
        /// <summary>
        /// Atk
        /// </summary>
        public int Atk { get { return _atk; } }

        private readonly int _mat;
        /// <summary>
        /// Mat
        /// </summary>
        public int Mat { get { return _mat; } }


        //引数が2個のコンストラクタ
        private Ap(int atk, int mat)
        {
            // 0より小さい時には例外を発生させる
            if(atk < 0 && mat < 0)
            {
                throw new ArgumentException("Atk and Mat value cannot be negative");
            }
            else if (atk < 0)
            {
                throw new ArgumentException("Atk value cannot be negative");
            }
            else if (mat < 0)
            {
                throw new ArgumentException("Mat value cannot be negative");
            }
            this._atk = atk;
            this._mat = mat;
        }

        //引数が１個の場合、this(Atk, Mat)の部分で上のコンストラクタを使用し、
        //同じ値をAtkとMapに代入している。
        public Ap(int value) : this(value, value) { }

        public Ap AddAtk(Ap value)
        {
            return new Ap(this._atk + value.Atk, this._mat);
        }

        public Ap AddMat(Ap value)
        {
            return new Ap(this._atk, this._mat + value.Mat);
        }

        public Ap SubtractAtk(Ap value)
        {
            return new Ap(this._atk - value.Atk, this._mat);
        }

        public Ap SubtractMat(Ap value)
        {
            return new Ap(this._atk, this._mat - value.Mat);
        }

        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, Atk : {this._atk}, Mat : {this._mat}.");
        }
    }
}
