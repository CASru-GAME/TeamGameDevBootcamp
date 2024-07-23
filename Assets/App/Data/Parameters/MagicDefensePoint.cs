using System;

namespace App.Data
{
    public class MagicDefensePoint
    {
        /// <summary>
        /// MagicDefensePoint
        /// </summary>
        private readonly int _currentValue;
        public int CurrentValue => _currentValue;

        //コンストラクタ
        public MagicDefensePoint(int value)
        {
            // 0より小さい時には例外を発生させる
            if (value < 0)
            {
                throw new ArgumentException("Magic Defence Point value cannot be negative");
            }
            this._currentValue = value;
        }

        public MagicDefensePoint AddCurrentValue(MagicDefensePoint value)
        {
            return new MagicDefensePoint(this._currentValue + value.CurrentValue);
        }

        public MagicDefensePoint SubtractCurrentValue(MagicDefensePoint value)
        {
            return new MagicDefensePoint(this._currentValue - value.CurrentValue);
        }

        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, MagicDefensePoint : {this._currentValue}.");
        }
    }
}
