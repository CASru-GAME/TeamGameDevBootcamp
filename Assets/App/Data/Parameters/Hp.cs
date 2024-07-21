using System;

namespace App.Data
{
    /// <summary>
    /// ゲーム内キャラクターのヘルスポイント（HP）を管理する
    /// </summary>
    /// <remarks>
    /// このHpクラスは、エンティティの最大HP（_maxHp）と現在のHP（_currentHp）を保持する
    /// MaxHpプロパティとCurrentHpプロパティを通じて、これらの値に安全にアクセスできる
    /// </remarks>
    /// <exception cref="ArgumentException">currentHpが0未満の場合、またはcurrentHpがmaxHpを超える場合に発生します。</exception>

    public class Hp
    {
        private readonly int _maxHp;
        /// <summary>
        /// 最大Hp
        /// </summary>
        public int MaxHp { get { return _maxHp; } }
        private readonly int _currentHp;
        /// <summary>
        /// 現在のHp
        /// </summary>
        public int CurrentHp { get { return _currentHp; } }

        /// <summary>
        /// このクラス内のみで使用するコンストラクタ。最大HPと現在のHPを指定してHPを初期化する
        /// </summary>
        /// <param name="currentHp">設定する現在のHPのint型の値</param>
        /// <param name="maxHp">設定するHPのint型の値</param>
        /// <exception cref="ArgumentException"></exception>
        private Hp(int currentHp, int maxHp)
        {
            // 0より小さい時には例外を発生させる
            if (currentHp < 0)
            {
                throw new ArgumentException("Value cannot be negative");
            }
            // maxHpを超える時には例外を発生させる
            else if (currentHp > maxHp)
            {
                throw new ArgumentException("Value cannot over maxHp");
            }
            this._currentHp = currentHp;
            this._maxHp = maxHp;
        }

        /// <summary>
        /// 入力された数値を最大HP・現在のHPとしてHPの初期化を行う
        /// </summary>
        /// <param name="maxHpValue">最大HP・現在のHPのint型の値</param>
        public Hp(int maxHpValue) : this(maxHpValue, maxHpValue) { }

        /// <summary>
        /// 現在のHPの値を増加する
        /// </summary>
        /// <param name="value">追加する現在のHPのインスタンス</param>
        /// <returns>現在のHPを追加した新しいHpインスタンス</returns>
        public Hp AddCurrentHp(Hp value)
        {
            if (this._currentHp + value.CurrentHp > this._maxHp)
            {
                return new Hp(this._maxHp, this._maxHp);
            }
            else
            {
                return new Hp(this._currentHp + value.CurrentHp, this._maxHp);
            }
        }

        /// <summary>
        /// 最大HPの値を増加する
        /// </summary>
        /// <param name="value">追加する最大HPのインスタンス</param>
        /// <returns>最大HPを追加した新しいHpインスタンス</returns>
        public Hp AddMaxHp(Hp value)
        {
            return new Hp(this._currentHp, this._maxHp + value.CurrentHp);
        }

        /// <summary>
        /// 現在のHPの値を減少する
        /// </summary>
        /// <param name="value">減少する現在のHPのインスタンス</param>
        /// <returns>最大HPを追加した新しいHpインスタンス</returns>
        public Hp SubstractCurrentHp(Hp value)
        {
            if (this._currentHp - value.CurrentHp < 0)
            {
                return new Hp(0,this._maxHp);
            }
            else
            {
                return new Hp(this._currentHp - value.CurrentHp, this._maxHp);
            }
        }

        /// <summary>
        /// 現在のHPと最大HPをログに表示する、デバッグ用メソッド
        /// </summary>
        /// <param name="message">ログに表示させたい文章</param>
        public void Dump(string message)
        {
            UnityEngine.Debug.Log($"Message : {message}, CurrentHp : {this._currentHp}, MaxHp : {this._maxHp}, ");
        }
    }
}
