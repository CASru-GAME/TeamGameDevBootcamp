using System;

namespace App.Common.Data
{
    public class MagicAttackPoint
    {
        /// <summary>
        /// MagicAttackPoint
        /// 魔法攻撃力
        /// </summary>F
        private readonly int _currentValue;
        public int CuurentValue => _currentValue;

        //コンストラクタ
        public MagicAttackPoint(int value)
        {
            // 0より小さい時には例外を発生させる
            if (value < 0)
            {
                throw new ArgumentException("Magic Attack Point value cannot be negative");
            }
            this._currentValue = value;
        }

        public MagicAttackPoint AddCurrentValue(MagicAttackPoint value)
        {
            return new MagicAttackPoint(this._currentValue + value.CuurentValue);
        }

        public MagicAttackPoint SubtractCurrentValue(MagicAttackPoint value)
        {
            return new MagicAttackPoint(this._currentValue - value.CuurentValue);
        }

        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, MagicAttackPoint : {this._currentValue}.");
        }
    }
}
