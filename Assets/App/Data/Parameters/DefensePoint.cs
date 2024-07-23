using System;

namespace App.Data
{
    public class DefensePoint
    {
        /// <summary>
        /// DefensePoint
        /// 物理防御力
        /// </summary>
        private readonly int _currentValue;
        public int CurrentValue => _currentValue;

        //コンストラクタ
        public DefensePoint(int value)
        {
            // 0より小さい時には例外を発生させる
            if (value < 0)
            {
                throw new ArgumentException("Defence Point value cannot be negative");
            }
            this._currentValue = value;
        }

        public DefensePoint AddCurrentValue(DefensePoint value)
        {
            return new DefensePoint(this._currentValue + value.CurrentValue);
        }

        public DefensePoint SubtractCurrentValue(DefensePoint value)
        {
            return new DefensePoint(this._currentValue - value.CurrentValue);
        }

        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, DefensePoint : {this._currentValue}.");
        }
    }
}
