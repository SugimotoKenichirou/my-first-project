# Project Overview
<!-- プロジェクトの概要、目的、使用技術 --> 

# Coding Style
<!-- 命名規則やスタイルガイド、コメントの書き方など -->
 - SQLはオブジェクト名（列名やテーブル名やストアドプロシジャー等）を除き大文字で記載する。
 - SQLは「SELECT」「副問い合わせ」「結合句」におけるテーブル句では必ずLOCK HINTを明示する。ただしLOCK HINTの明示はフレームワーク・ライブラリ(DAC)を使用する。
 - "SELECT"SQLにおいては原則"*"を使用せず、必要な列名を記述する。

# Folder Structure
<!-- プロジェクトの構造と役割分担 -->
 - InterfaceのClass名は「I」で始める。

# Conventions
<!-- フレームワーク・ライブラリの使い方、設計原則 -->
## ISNULLの対応について

## LOCK HINTの記載方法について

### NOLOCK HINTについて

``` c#
 sql = "SELECT 列リスト FROM ターブル名 " + DAC.WithNoLock() + " WHERE句";
```

### ROW ROCKについて
### TABLE LOCKについて

## INDEX HINTの記載方法について

# Don'ts
<!-- 避けるべき書き方や使用禁止ライブラリなど -->
 - SQLのコマンドに"ISULL"メソッドの使用を禁止する。{## ISNULL対応について}に従ってください。
 - 結合SQLにおける"CROSS JOIN"の使用は禁止とする。
 - HINT句におけるINDEX名はINDEX名を直接記載せずフレームワーク・ライブラリを使用する。
 - SQLコマンドに置いて"TRIM"メソッドの使用は禁止する。

# Additional Context
<!-- 環境、依存、ビルド方法、使用制限などの補足情報 -->