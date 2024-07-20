using App.Data;
using UnityEngine;

// 実際に使用するときのコードがきもい
// コンストラクタがミスってた（代入出来てなかった）

public class TestHp : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Hp hp = new(100); で全て初期化している");

        Debug.Log("コンストラクタのテスト");

        TestConstructor();

        Debug.Log("プロパティのテスト");

        TestProperty();

        Debug.Log("AddCurrentHpのテスト");

        TestAddCurrentHp();

        Debug.Log("SubstractCurrentHpのテスト");

        TestSubstractCurrentHp();

        Debug.Log("AddMaxHpのテスト");

        TestAddMaxHp();
    }

    private void TestConstructor()
    {
        // MaxHp : 100, CurrentHp : 100で初期設定
        Hp hp = new(100);

        // MaxHpとCurrentHpは違う値で初期設定できない
        // Hp errorHp = new(100, 50);

        // 初期HPを表示 (100,100)
        hp.Dump("初期HPを表示 : (100,100)");
    }

    private void TestProperty()
    {
        Hp hp = new(100);

        // 現在のHPを表示 (100)
        Debug.Log($"Message : 現在のHPを表示 (100), CurrentHp : {hp.CurrentHp}");

        // 最大HPを表示 (100)
        Debug.Log($"Message : 最大HPを表示 (100), MaxHp : {hp.MaxHp}");

        // 現在のHPを書き換える (Error)
        // hp.CurrentHp = 80;

        // 最大HPを書き換える (Error)
        // hp.MaxHp = 80;
    }

    private void TestAddCurrentHp()
    {
        Hp hp = new(100);

        // 現在のHPを50増やす（変化なし）
        Hp overRecoveredHp = hp.AddCurrentHp(new Hp(50));

        // (100,100)
        overRecoveredHp.Dump("50回復した後。過回復で変化なし : (100,100)");

        // 現在のHPを50減らす
        Hp damagedHp = overRecoveredHp.SubstractCurrentHp(new Hp(50));

        // (100,50)
        damagedHp.Dump("50ダメージを与えた後 : (100,50)");

        // 現在のHPを30増やす
        Hp recoveredHp = damagedHp.AddCurrentHp(new Hp(30));

        // (100,80)
        recoveredHp.Dump("30回復した後 : (100,80)");
    }

    private void TestSubstractCurrentHp()
    {
        Hp hp = new(100);

        // ここから命名ちゃんと書くの諦めました
        // 現在のHPを50減らす
        Hp hp1 = hp.SubstractCurrentHp(new Hp(50));

        // (100,50)
        hp1.Dump("50ダメージを与えた後 : (100,50)");

        // 現在のHPを50減らす
        Hp hp2 = hp1.SubstractCurrentHp(new Hp(50));

        // (100,0)
        hp2.Dump("さらに50ダメージを与えた後 : (100,0)");

        // 現在のHPを50減らす
        Hp hp3 = hp2.SubstractCurrentHp(new Hp(50));

        // (100,0)
        hp3.Dump("さらに50ダメージを与えた後。0未満にならない : (100,0)");
    }

    private void TestAddMaxHp()
    {
        Hp hp = new(100);

        // 最大HPを50増やす
        Hp hp1 = hp.AddMaxHp(new Hp(50));

        // (150,100)
        hp1.Dump("最大HPを50増やした後 : (150,100)");
    }
}
