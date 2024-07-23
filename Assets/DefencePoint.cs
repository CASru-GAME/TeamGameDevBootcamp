using System;

namespace App.Data
{
    public class DefencePoint
    {

        private readonly int _defencePoint;
        /// <summary>
        /// DefencePoint
        /// 物理防御力
        /// </summary>
        public int DefencePointValue { get { return _defencePoint; } }

        //コンストラクタ
        public DefencePoint(int defencePoint)
        {
            // 0より小さい時には例外を発生させる
            if (defencePoint < 0)
            {
                throw new ArgumentException("Defence Point value cannot be negative");
            }
            this._defencePoint = defencePoint;

        }

        public DefencePoint AddDefencePoint(DefencePoint value)
        {
            return new DefencePoint(this._defencePoint + value.DefencePointValue);
        }


        public DefencePoint SubtractDefencePoint(DefencePoint value)
        {
            return new DefencePoint(this._defencePoint - value.DefencePointValue);
        }


        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, DefencePoint : {this._defencePoint}.");
        }
    }
}
