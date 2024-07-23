using System;

namespace App.Data
{
    /// <summary>
    /// ゲーム内キャラクターのマジックポイント（MagicPoint, Mp）を管理する
    /// </summary>
    /// <remarks>
    /// このMpクラスは、エンティティの最大Mp（_maxValue）と現在のMp（_currentValue）を保持する
    /// MaxValueプロパティとCurrentValueプロパティを通じて、これらの値に安全にアクセスできる
    /// </remarks>
    /// <exception cref="ArgumentException">CurrentValueが0未満の場合、またはCurrentValueがMaxValueを超える場合に発生します。</exception>

    public class MagicPoint
    {
        private readonly int _currentValue;
        /// <summary>
        /// 現在のMp
        /// </summary>
        public int CurrentValue => _currentValue;
        private readonly int _maxValue;
        /// <summary>
        /// 最大Mp
        /// </summary>
        public int MaxValue => _maxValue;

        /// <summary>
        /// このクラス内のみで使用するコンストラクタ。最大Mpと現在のMpを指定してMpを初期化する
        /// </summary>
        /// <param name="CurrentValue">設定する現在のMpのint型の値</param>
        /// <param name="MaxValue">設定するMpのint型の値</param>
        /// <exception cref="ArgumentException"></exception>
        private MagicPoint(int currentValue, int maxValue)
        {
            // 0より小さい時には例外を発生させる
            if (currentValue < 0)
            {
                throw new ArgumentException("Value cannot be negative");
            }
            // MaxValueを超える時には例外を発生させる
            else if (currentValue > maxValue)
            {
                throw new ArgumentException("Value cannot over MaxValue");
            }
            this._currentValue = currentValue;
            this._maxValue = maxValue;
        }

        /// <summary>
        /// 入力された数値を最大Mp・現在のMpとしてMpの初期化を行う
        /// </summary>
        /// <param name="value">最大Mp・現在のMpのint型の値</param>
        public MagicPoint(int value) : this(value, value) { }

        /// <summary>
        /// 現在のMpの値を増加する
        /// </summary>
        /// <param name="value">追加する現在のMpのインスタンス</param>
        /// <returns>現在のMpを追加した新しいMpインスタンス</returns>
        public MagicPoint AddCurrentValue(MagicPoint value)
        {
            if (this._currentValue + value.CurrentValue > this._maxValue)
            {
                return new MagicPoint(this._maxValue, this._maxValue);
            }
            else
            {
                return new MagicPoint(this._currentValue + value.CurrentValue, this._maxValue);
            }
        }

        /// <summary>
        /// 最大Mpの値を増加する
        /// </summary>
        /// <param name="value">追加する最大Mpのインスタンス</param>
        /// <returns>最大Mpを追加した新しいMpインスタンス</returns>
        public MagicPoint AddMaxValue(MagicPoint value)
        {
            return new MagicPoint(this._currentValue, this._maxValue + value.CurrentValue);
        }

        /// <summary>
        /// 現在のMpの値を減少する
        /// </summary>
        /// <param name="value">減少する現在のMpのインスタンス</param>
        /// <returns>最大Mpを追加した新しいMpインスタンス</returns>
        public MagicPoint SubtractCurrentValue(MagicPoint value)
        {
            if (this._currentValue - value.CurrentValue < 0)
            {
                return new MagicPoint(0,this._maxValue);
            }
            else
            {
                return new MagicPoint(this._currentValue - value.CurrentValue, this._maxValue);
            }
        }

        /// <summary>
        /// 現在のMpと最大Mpをログに表示する、デバッグ用メソッド
        /// </summary>
        /// <param name="message">ログに表示させたい文章</param>
        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, CurrentValue : {this._currentValue}, MaxValue : {this._maxValue}, ");
        }
    }
}
