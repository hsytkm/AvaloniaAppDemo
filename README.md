# AvaloniaAppDemo

2023.4.23

会社で 『Linux GUI アプリ』 のワードを聞いたので Avalonia を試してみる。（Linux/Mac の確認環境がないけど…）

## Avalonia UI とは？

うっすら知ってるけど改めてまとめます。

- Windows, Linux, macOS をサポートする、柔軟なスタイリングシステムを提供する .NET のクロスプラットフォームUIフレームワーク
- MITライセンス
- WPFのコードネームが「Avalon」で、「Avalonia」は「現代のC#の機能を使ってWPFを再実装しようとしたらどうなるだろう」というところから始まったらしい。
- ほぼ WPF だけど直接移植されておらず、全く同じではない。

**Avalonia XPF**

商用フレームワークとして新たに用意しようとしてて、そちらはガチで WPF 互換っぽい。2024年には WebAssembly, iOS, Android もサポートする予定とか。 有償なので縁がなさそう。

## 導入準備

1. VS拡張機能の `Avalonia for Visual Studio 2022` をインストール する
2. 新しいプロジェクトで `Avalonia .NET Core MVVM App (AvaloniaUI)` を選択する。
3. MVVM Toolkit として、`ReactiveUI` と `CommunityToolkit` の2つが選択できる。 `CommunityToolkit` 派
4. Avalonia Version は `10` か `11-prev4` が選べて `11-prev4` にしてみた。 何も知らないので新しい方を試したい。

## ソリューション

比較のため Avalonia と WPF の View をそれぞれ用意し、ViewMode と Model は別project に分けて共通で使用してみた。

## 味見での気づき

- SinglePublish の Windows.exeファイルサイズが Avalonia: 86MByte, WPF: 155MByte で、Avalonia の方が 45% くらい縮んでいてビビった。
- Avalonia だと Windows で絵文字がカラー表示される。
- 11.0 は Preview なのでバージョンアップでビルドエラーなることが多い → [Breaking Changes](https://github.com/AvaloniaUI/Avalonia/wiki/Breaking-Changes)

## References

[Welcome - Avalonia UI](https://docs.avaloniaui.net/)

[AvaloniaUI/Avalonia: A cross-platform UI framework for .NET - Github](https://github.com/AvaloniaUI/Avalonia)

[Breaking Changes - AvaloniaUI/Avalonia Wiki](https://github.com/AvaloniaUI/Avalonia/wiki/Breaking-Changes)
