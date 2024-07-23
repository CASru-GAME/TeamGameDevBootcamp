using System;

namespace App.Data
{
    public class AttackPoint
    {

        private readonly int _attackPoint;
        /// <summary>
        /// AttackPoint
        /// 物理攻撃力
        /// </summary>
        public int AttackPointValue { get { return _attackPoint; } }

        //コンストラクタ
        public AttackPoint(int attackPoint)
        {
            // 0より小さい時には例外を発生させる
            if (attackPoint < 0)
            {
                throw new ArgumentException("Attack point value cannot be negative");
            }
            this._attackPoint = attackPoint;

        }

        public AttackPoint AddAttackPoint(AttackPoint value)
        {
            return new AttackPoint(this._attackPoint + value.AttackPointValue);
        }


        public AttackPoint SubtractAttackPoint(AttackPoint value)
        {
            return new AttackPoint(this._attackPoint - value.AttackPointValue);
        }


        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, AttackPoint : {this._attackPoint}.");
        }
    }
}
