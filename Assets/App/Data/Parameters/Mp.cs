using System;

namespace App.Data
{
    /// <summary>
    /// ゲーム内キャラクターのヘルスポイント（Mp）を管理する
    /// </summary>
    /// <remarks>
    /// このMpクラスは、エンティティの最大Mp（_maxMp）と現在のMp（_currentMp）を保持する
    /// MaxMpプロパティとCurrentMpプロパティを通じて、これらの値に安全にアクセスできる
    /// </remarks>
    /// <exception cref="ArgumentException">currentMpが0未満の場合、またはcurrentMpがmaxMpを超える場合に発生します。</exception>

    public class Mp
    {
        private readonly int _maxMp;
        /// <summary>
        /// 最大Mp
        /// </summary>
        public int MaxMp { get { return _maxMp; } }
        private readonly int _currentMp;
        /// <summary>
        /// 現在のMp
        /// </summary>
        public int CurrentMp { get { return _currentMp; } }

        /// <summary>
        /// このクラス内のみで使用するコンストラクタ。最大Mpと現在のMpを指定してMpを初期化する
        /// </summary>
        /// <param name="currentMp">設定する現在のMpのint型の値</param>
        /// <param name="maxMp">設定するMpのint型の値</param>
        /// <exception cref="ArgumentException"></exception>
        private Mp(int currentMp, int maxMp)
        {
            // 0より小さい時には例外を発生させる
            if (currentMp < 0)
            {
                throw new ArgumentException("Value cannot be negative");
            }
            // maxMpを超える時には例外を発生させる
            else if (currentMp > maxMp)
            {
                throw new ArgumentException("Value cannot over maxMp");
            }
            this._currentMp = currentMp;
            this._maxMp = maxMp;
        }

        /// <summary>
        /// 入力された数値を最大Mp・現在のMpとしてMpの初期化を行う
        /// </summary>
        /// <param name="maxMpValue">最大Mp・現在のMpのint型の値</param>
        public Mp(int maxMpValue) : this(maxMpValue, maxMpValue) { }

        /// <summary>
        /// 現在のMpの値を増加する
        /// </summary>
        /// <param name="value">追加する現在のMpのインスタンス</param>
        /// <returns>現在のMpを追加した新しいMpインスタンス</returns>
        public Mp AddCurrentMp(Mp value)
        {
            if (this._currentMp + value.CurrentMp > this._maxMp)
            {
                return new Mp(this._maxMp, this._maxMp);
            }
            else
            {
                return new Mp(this._currentMp + value.CurrentMp, this._maxMp);
            }
        }

        /// <summary>
        /// 最大Mpの値を増加する
        /// </summary>
        /// <param name="value">追加する最大Mpのインスタンス</param>
        /// <returns>最大Mpを追加した新しいMpインスタンス</returns>
        public Mp AddMaxMp(Mp value)
        {
            return new Mp(this._currentMp, this._maxMp + value.CurrentMp);
        }

        /// <summary>
        /// 現在のMpの値を減少する
        /// </summary>
        /// <param name="value">減少する現在のMpのインスタンス</param>
        /// <returns>最大Mpを追加した新しいMpインスタンス</returns>
        public Mp SubtractCurrentMp(Mp value)
        {
            if (this._currentMp - value.CurrentMp < 0)
            {
                return new Mp(0,this._maxMp);
            }
            else
            {
                return new Mp(this._currentMp - value.CurrentMp, this._maxMp);
            }
        }

        /// <summary>
        /// 現在のMpと最大Mpをログに表示する、デバッグ用メソッド
        /// </summary>
        /// <param name="message">ログに表示させたい文章</param>
        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, CurrentMp : {this._currentMp}, MaxMp : {this._maxMp}, ");
        }
    }
}
