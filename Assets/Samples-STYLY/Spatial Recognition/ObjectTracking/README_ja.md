# Object Tracking サンプル

このプロジェクトは、STYLYでのObject Trackingのサンプルプロジェクトです。

## 注意事項

このプロジェクトには、トレーニング済みの `referenceobject` は含まれていません。  
そのため、以下の手順で独自の `referenceobject` を用意し、`ReferenceObjectLibrary` に追加してください。

### 手順

1. **トレーニング用のオブジェクトを準備**  
   トラッキング対象のオブジェクトを用意し、必要に応じて3Dスキャンや画像データを取得します。

2. **トレーニングを実行**  
   `referenceobject` の生成手順については、以下の公式ドキュメントを参照してください:  
   [Implementing Object Tracking in Your visionOS App](https://developer.apple.com/documentation/visionOS/implementing-object-tracking-in-your-visionOS-app)

3. **`referenceobject` をプロジェクトにインポート**  
   トレーニングで生成された `.referenceobject` ファイルを、このプロジェクトの適切なフォルダに追加します。

4. **`ReferenceObjectLibrary` に登録**  
   Unityエディタで `ReferenceObjectLibrary.asset` を開き、インポートした `referenceobject` をライブラリに追加します。

5. **STYLYにアップロード**  
   必要に応じて、プロジェクト全体をSTYLYにアップロードし、Object Trackingを利用します。

## ファイル構成

- `Object Tracking (Upload this prefab to STYLY).prefab`  
  STYLYにアップロードするためのプレハブです。

- `ReferenceObjectLibrary.asset`  
  トラッキング対象のオブジェクトを管理するライブラリです。
