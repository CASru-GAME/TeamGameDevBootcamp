using System;

namespace App.Common.Data
{
    /// <summary>
    /// ゲーム内キャラクターの経験値（EXP）を管理する
    /// </summary>
    /// <remarks>
    /// このExpクラスは、エンティティの最大EXP（_maxValue）と現在のEXP（_currentValue）を保持する
    /// MaxValueプロパティとCurrentValueプロパティを通じて、これらの値に安全にアクセスできる
    /// </remarks>
    /// <exception cref="ArgumentException">CurrentValueが0未満の場合、またはCurrentValueがMaxValueを超える場合に発生します。</exception>

    public class ExperiencePoint
    {
        private readonly int _currentValue;
        /// <summary>
        /// 現在のExp
        /// </summary>
        public int CurrentValue => _currentValue;
        private readonly int _maxValue;
        /// <summary>
        /// 最大Exp
        /// </summary>
        public int MaxValue => _maxValue;

        /// <summary>
        /// このクラス内外で使用するコンストラクタ。最大EXPと現在のEXPを指定してEXPを初期化する
        /// </summary>
        /// <param name="CurrentValue">設定する現在のEXPのint型の値</param>
        /// <param name="MaxValue">設定するEXPのint型の値</param>
        /// <exception cref="ArgumentException"></exception>
        public ExperiencePoint(int CurrentValue, int MaxValue)
        {
            // 0より小さい時には例外を発生させる
            if (CurrentValue < 0)
            {
                throw new ArgumentException("Value cannot be negative");
            }
            // MaxValueを超える時には例外を発生させる
            else if (CurrentValue > MaxValue)
            {
                throw new ArgumentException("Value cannot over MaxValue");
            }
            this._currentValue = CurrentValue;
            this._maxValue = MaxValue;
        }

        /// <summary>
        /// 現在のEXPの値を増加する
        /// </summary>
        /// <param name="value">追加する現在のEXPのインスタンス</param>
        /// <returns>現在のEXPを追加した新しいExpインスタンス</returns>
        public ExperiencePoint AddCurrentValue(ExperiencePoint value)
        {
            if (this._currentValue + value.CurrentValue > this._maxValue)
            {
                return new ExperiencePoint(this._maxValue, this._maxValue);
            }
            else
            {
                return new ExperiencePoint(this._currentValue + value.CurrentValue, this._maxValue);
            }
        }

        /// <summary>
        /// 最大EXPの値を増加する
        /// </summary>
        /// <param name="value">追加する最大EXPのインスタンス</param>
        /// <returns>最大EXPを追加した新しいExpインスタンス</returns>
        public ExperiencePoint AddMaxValue(ExperiencePoint value)
        {
            return new ExperiencePoint(this._currentValue, this._maxValue + value.CurrentValue);
        }
        
        /// <summary>
        /// 現在のEXPと最大EXPをログに表示する、デバッグ用メソッド
        /// </summary>
        /// <param name="message">ログに表示させたい文章</param>
        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, CurrentValue : {this._currentValue}, MaxValue : {this._maxValue}, ");
        }
    }
}