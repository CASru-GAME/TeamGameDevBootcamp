using System;

namespace App.Data
{
    public class MagicAttackPoint
    {

        private readonly int _magicAttackPoint;
        /// <summary>
        /// MagicAttackPoint
        /// 魔法攻撃力
        /// </summary>
        public int MagicAttackPointValue { get { return _magicAttackPoint; } }

        //コンストラクタ
        public MagicAttackPoint(int magicAttackPoint)
        {
            // 0より小さい時には例外を発生させる
            if (magicAttackPoint < 0)
            {
                throw new ArgumentException("Magic Attack Point value cannot be negative");
            }
            this._magicAttackPoint = magicAttackPoint;

        }

        public MagicAttackPoint AddMagicAttackPoint(MagicAttackPoint value)
        {
            return new MagicAttackPoint(this._magicAttackPoint + value.MagicAttackPointValue);
        }


        public MagicAttackPoint SubtractMagicAttackPoint(MagicAttackPoint value)
        {
            return new MagicAttackPoint(this._magicAttackPoint - value.MagicAttackPointValue);
        }


        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, MagicAttackPoint : {this._magicAttackPoint}.");
        }
    }
}
