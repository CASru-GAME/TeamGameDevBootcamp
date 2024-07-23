using System;

namespace App.Data
{
    public class MagicDefencePoint
    {

        private readonly int _magicDefencePoint;
        /// <summary>
        /// MagicDefencePoint
        /// </summary>
        public int MagicDefencePointValue { get { return _magicDefencePoint; } }

        //コンストラクタ
        public MagicDefencePoint(int magicDefencePoint)
        {
            // 0より小さい時には例外を発生させる
            if (magicDefencePoint < 0)
            {
                throw new ArgumentException("Magic Defence Point value cannot be negative");
            }
            this._magicDefencePoint = magicDefencePoint;

        }

        public MagicDefencePoint AddMagicDefencePoint(MagicDefencePoint value)
        {
            return new MagicDefencePoint(this._magicDefencePoint + value.MagicDefencePointValue);
        }


        public MagicDefencePoint SubtractMagicDefencePoint(MagicDefencePoint value)
        {
            return new MagicDefencePoint(this._magicDefencePoint - value.MagicDefencePointValue);
        }


        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, MagicDefencePoint : {this._magicDefencePoint}.");
        }
    }
}
