using App.Common.Data;
using UnityEngine;

public class TestHp : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Hp hp = new(100); で全て初期化している");

        Debug.Log("コンストラクタのテスト");

        TestConstructor();

        Debug.Log("プロパティのテスト");

        TestProperty();

        Debug.Log("AddCurrentValueのテスト");

        TestAddCurrentValue();

        Debug.Log("SubtractCurrentValueのテスト");

        TestSubtractCurrentValue();

        Debug.Log("AddMaxValueのテスト");

        TestAddMaxValue();
    }

    private void TestConstructor()
    {
        // MaxValue : 100, CurrentValue : 100で初期設定
        HealthPoint hp = new(100);

        // MaxValueとCurrentValueは違う値で初期設定できない
        // Hp errorHp = new(50, 100);

        // 初期HPを表示 (100,100)
        hp.Dump("初期HPを表示 : (100,100)");
    }

    private void TestProperty()
    {
        HealthPoint hp = new(100);

        // 現在のHPを表示 (100)
        Debug.Log($"Message : 現在のHPを表示 (100), CurrentValue : {hp.CurrentValue}");

        // 最大HPを表示 (100)
        Debug.Log($"Message : 最大HPを表示 (100), MaxValue : {hp.MaxValue}");

        // 現在のHPを書き換える (Error)
        // hp.CurrentValue = 80;

        // 最大HPを書き換える (Error)
        // hp.MaxValue = 80;
    }

    private void TestAddCurrentValue()
    {
        HealthPoint hp = new(100);

        // 現在のHPを50増やす（変化なし）
        HealthPoint overRecoveredHp = hp.AddCurrentValue(new HealthPoint(50));

        // (100,100)
        overRecoveredHp.Dump("50回復した後。過回復で変化なし : (100,100)");

        // 現在のHPを50減らす
        HealthPoint damagedHp = overRecoveredHp.SubtractCurrentValue(new HealthPoint(50));

        // (50,100)
        damagedHp.Dump("50ダメージを与えた後 : (50,100)");

        // 現在のHPを30増やす
        HealthPoint recoveredHp = damagedHp.AddCurrentValue(new HealthPoint(30));

        // (80,100)
        recoveredHp.Dump("30回復した後 : (80,100)");
    }

    private void TestSubtractCurrentValue()
    {
        HealthPoint hp = new(100);

        // 現在のHPを50減らす
        HealthPoint hp1 = hp.SubtractCurrentValue(new HealthPoint(50));

        // (50,100)
        hp1.Dump("50ダメージを与えた後 : (50,100)");

        // 現在のHPを50減らす
        HealthPoint hp2 = hp1.SubtractCurrentValue(new HealthPoint(50));

        // (0,100)
        hp2.Dump("さらに50ダメージを与えた後 : (0,100)");

        // 現在のHPを50減らす
        HealthPoint hp3 = hp2.SubtractCurrentValue(new HealthPoint(50));

        // (0,100)
        hp3.Dump("さらに50ダメージを与えた後。0未満にならない : (0,100)");
    }

    private void TestAddMaxValue()
    {
        HealthPoint hp = new(100);

        // 最大HPを50増やす
        HealthPoint hp1 = hp.AddMaxValue(new HealthPoint(50));

        // (100,150)
        hp1.Dump("最大HPを50増やした後 : (100,150)");
    }
}