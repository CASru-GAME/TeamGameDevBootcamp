using System;

namespace App.Data
{
    public class AttackPoint
    {
        /// <summary>
        /// AttackPoint
        /// 物理攻撃力
        /// </summary>
        private readonly int _currentValue;
        public int CurrentValue => _currentValue;

        //コンストラクタ
        public AttackPoint(int value)
        {
            // 0より小さい時には例外を発生させる
            if (value < 0)
            {
                throw new ArgumentException("Attack point value cannot be negative");
            }
            this._currentValue = value;
        }

        public AttackPoint AddCurrentValue(AttackPoint value)
        {
            return new AttackPoint(this._currentValue + value.CurrentValue);
        }

        public AttackPoint SubtractCurrentValue(AttackPoint value)
        {
            return new AttackPoint(this._currentValue - value.CurrentValue);
        }

        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, AttackPoint : {this._currentValue}.");
        }
    }
}
