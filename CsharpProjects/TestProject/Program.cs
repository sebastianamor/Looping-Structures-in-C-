// ペットデータ
const int maxPets = 8;
string[,] ourAnimals = new string[maxPets, 6];

// サンプルデータで配列を初期化
for (int i = 0; i < 4; i++)
{
    ourAnimals[i, 0] = "ID #: ID" + i;
    ourAnimals[i, 1] = "種類: " + (i % 2 == 0 ? "犬" : "猫");
    ourAnimals[i, 2] = "年齢: " + (i + 1) + "歳";
    ourAnimals[i, 3] = "ニックネーム: ペット" + i;
    ourAnimals[i, 4] = "外見の特徴: " + (i % 2 == 0 ? "小型、短毛" : "中型、長毛");
    ourAnimals[i, 5] = "性格: " + (i % 2 == 0 ? "遊び好き" : "穏やか");
}

string menuSelection = "";
do
{
    Console.WriteLine("\nメインメニュー:");
    Console.WriteLine("1. すべてのペットを表示");
    Console.WriteLine("2. 新しいペットを追加");
    Console.WriteLine("3. ペット情報を編集");
    Console.WriteLine("4. ペットを検索");
    Console.WriteLine("exit - プログラムを終了");
    Console.Write("選択してください: ");

    menuSelection = Console.ReadLine()?.Trim().ToLower();

    switch (menuSelection)
    {
        case "1":
            Console.WriteLine("\nペット一覧:");
            for (int i = 0; i < maxPets; i++)
            {
                if (!string.IsNullOrEmpty(ourAnimals[i, 0]))
                {
                    Console.WriteLine($"\nペット {i}:");
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n続けるにはEnterキーを押してください...");
            Console.ReadLine();
            break;

        case "2":
            string もう一度;
            do
            {
                int petCount = 0;
                int 新しい位置 = -1;

                // ペットをカウントして空き位置を探す
                for (int i = 0; i < maxPets; i++)
                {
                    if (!string.IsNullOrEmpty(ourAnimals[i, 0]))
                    {
                        petCount++;
                    }
                    else if (新しい位置 == -1)
                    {
                        新しい位置 = i;
                    }
                }

                if (petCount >= maxPets)
                {
                    Console.WriteLine("\n登録可能なペット数の上限に達しました！");
                    break;
                }

                Console.WriteLine(
                    $"\n現在 {petCount}匹のペットが登録されています。あと{(maxPets - petCount)}匹登録できます。"
                );

                // 種類を検証（犬または猫）
                string 動物の種類;
                bool 有効な入力;
                do
                {
                    Console.Write("\n種類を入力してください（犬/猫）: ");
                    動物の種類 = Console.ReadLine()?.Trim().ToLower();
                    有効な入力 = 動物の種類 == "犬" || 動物の種類 == "猫";
                    if (!有効な入力)
                    {
                        Console.WriteLine("無効な種類です。'犬'または'猫'を入力してください。");
                    }
                } while (!有効な入力);

                // IDを生成（D1, D2, C3など）
                string 動物ID = 動物の種類.Substring(0, 1).ToUpper() + (petCount + 1).ToString();

                // 年齢を取得
                string 動物の年齢;
                do
                {
                    Console.Write("ペットの年齢を入力してください（不明な場合は?）: ");
                    動物の年齢 = Console.ReadLine()?.Trim();
                    if (動物の年齢 != "?")
                    {
                        有効な入力 = int.TryParse(動物の年齢, out _);
                        if (!有効な入力)
                        {
                            Console.WriteLine("無効な年齢です。数字または?を入力してください。");
                        }
                    }
                    else
                    {
                        有効な入力 = true;
                    }
                } while (!有効な入力);

                // ニックネームを取得
                Console.Write("ニックネーム: ");
                string 動物のニックネーム = Console.ReadLine()?.Trim();
                動物のニックネーム = string.IsNullOrEmpty(動物のニックネーム)
                    ? "なし"
                    : 動物のニックネーム;

                // 外見の特徴を取得
                Console.Write("外見の特徴: ");
                string 動物の外見 = Console.ReadLine()?.Trim();
                動物の外見 = string.IsNullOrEmpty(動物の外見) ? "未設定" : 動物の外見;

                // 性格を取得
                Console.Write("性格: ");
                string 動物の性格 = Console.ReadLine()?.Trim();
                動物の性格 = string.IsNullOrEmpty(動物の性格) ? "未設定" : 動物の性格;

                // 情報を指定された形式で保存
                ourAnimals[新しい位置, 0] = "ID #: " + 動物ID;
                ourAnimals[新しい位置, 1] = "種類: " + 動物の種類;
                ourAnimals[新しい位置, 2] = "年齢: " + 動物の年齢;
                ourAnimals[新しい位置, 3] = "ニックネーム: " + 動物のニックネーム;
                ourAnimals[新しい位置, 4] = "外見の特徴: " + 動物の外見;
                ourAnimals[新しい位置, 5] = "性格: " + 動物の性格;

                Console.WriteLine("\nペットが正常に追加されました！");

                if (petCount + 1 < maxPets)
                {
                    Console.Write("\n別のペットを追加しますか？（はい/いいえ）: ");
                    もう一度 = Console.ReadLine()?.Trim().ToLower();
                }
                else
                {
                    Console.WriteLine("\n登録可能なペット数の上限に達しました！");
                    もう一度 = "いいえ";
                }
            } while (もう一度 == "はい");

            Console.WriteLine("\n続けるにはEnterキーを押してください...");
            Console.ReadLine();
            break;

        case "3":
            Console.WriteLine("\nこの機能は現在開発中です - 近日公開予定");
            Console.WriteLine("続けるにはEnterキーを押してください...");
            Console.ReadLine();
            break;

        case "4":
            Console.WriteLine("\nこの機能は現在開発中です - 近日公開予定");
            Console.WriteLine("続けるにはEnterキーを押してください...");
            Console.ReadLine();
            break;

        case "exit":
            Console.WriteLine("\nプログラムを終了します...");
            break;

        default:
            Console.WriteLine("\n無効な選択です。もう一度試してください。");
            break;
    }
} while (menuSelection != "exit");
