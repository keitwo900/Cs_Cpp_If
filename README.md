# Cs_Cpp_IF (C# - C++ Interface Sample)

## 本リポジトリについて
本リポジトリは、C#-ネイティブコード間でデータをやり取りするための、
Visual Studioでの環境構築のサンプルです。
Visual Studio Community 2017を使用しています。
UI部はC#で作成し、アルゴリズムはネイティブコード(C++やC言語)で高速に処理したい場合などに有効です。

## プロジェクト構成
Cs_Cpp_If: C#のプロジェクトです。Windows Formアプリケーションが生成されます。サンプルUIとして、整数の足し算のデータ入出力と実行ボタンがあります。</br>
Cpp_CLR: C#とネイティブコードをつなぐラッパのプロジェクトです。 C#プロジェクトで使用されるDLLが生成されます。</br>
Cpp: ネイティブコードプロジェクトです。CLRプロジェクトで取り込まれるlibが生成されます。

## 各プロジェクトでの設定
ここでは、各プロジェクトで設定すべき主要な項目(プロパティ等)を説明します。</br>

- Cs_Cpp_If
  - ソリューションエクスプローラーで、参照にCLRプロジェクトを追加
    - 参照を右クリック→「参照の追加」)で開いた画面で、「プロジェクト」→(ソリューション内にあるCpp_CLRを追加)
  - 必須ではないが、Formのソースコードで、CLRプロジェクトのnamespaceをusingで書いておくと、CLRプロジェクトのクラス名だけでクラスのオブジェクトが宣言できる。
    - using CppCLR; 
- Cpp_CLR
  - 作成時、「CLR クラス ライブラリ」で作成
  - プロパティー「リンカー」→「全般」→「インクリメンタルリンクを有効にする」→「いいえ(/INCREMENTAL:NO)」選択 (警告を避けるため)
  - ネイティブコードのスタティックリンクライブラリCpp.libをリンクの入力に追加
  - ネイティブコードの関数を使用するソースファイル内で、ネイティブコードのヘッダファイルをインクルードする。
    - インクルード時は、CLRプロジェクトから見た相対パスを入れるか、プロジェクトのプロパティ→C/C++→追加のインクルードディレクトリで、ネイティブコードのヘッダファイルのあるパスを追加する。
- Cpp
  - 作成時、「スタティック ライブラリ」で作成
  - プロジェクトのプロパティ→C/C++→全般→デバッグ情報の形式を、「ZI」から「Zi」に変更。(Cpp_CLRのビルドでWarning LNK4075が出るため。)
  - プロジェクトのプロパティ→C/C++→プリコンパイル済みヘッダー→プリコンパイル済みヘッダーを、「プリコンパイル済みヘッダーを使用しない」に変更
  - プロジェクトのプロパティ→C/C++→詳細設定→コンパイル言語の選択を規定→TPに変更(C言語のソースコードでネイティブのlibを作成したため。C++のソースコードならこの変更は不要)

# LISENCE
MIT License

Copyright (c) 2022 keitwo

Permission is hereby granted, free of charge, to any person obtaining a copy</br>
of this software and associated documentation files (the "Software"), to deal</br>
in the Software without restriction, including without limitation the rights</br>
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell</br>
copies of the Software, and to permit persons to whom the Software is</br>
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all</br>
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR</br>
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,</br>
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE</br>
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER</br>
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,</br>
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE</br>
SOFTWARE.