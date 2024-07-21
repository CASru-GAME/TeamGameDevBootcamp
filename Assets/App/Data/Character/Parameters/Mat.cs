using System;

namespace App.Data
{
    public class Mat
    {

        private readonly int _mat;
        /// <summary>
        /// Mat
        /// </summary>
        public int MatValue { get { return _mat; } }

        //コンストラクタ
        public Mat(int mat)
        {
            // 0より小さい時には例外を発生させる
            if (mat < 0)
            {
                throw new ArgumentException("Mat value cannot be negative");
            }
            this._mat = mat;

        }

        public Mat AddMat(Mat value)
        {
            return new Mat(this._mat + value.MatValue);
        }


        public Mat SubtractMat(Mat value)
        {
            return new Mat(this._mat - value.MatValue);
        }


        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, Mat : {this._mat}.");
        }
    }
}
