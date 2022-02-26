# Town Of Host
[![TownOfHost-Title](./Images/TownOfHost-Title.png)](https://youtu.be/IGguGyq_F-c)

## このModについて
このModは非公式のものであり、このModの開発に関してAmong Usの開発元である"Innersloth"は一切関与していません。<br>
このModの問題などに関して公式に問い合わせないでください。<br>

[![Discord](./Images/TownOfHost-Discord.png)](https://discord.gg/v8SFfdebpz)

## 特徴
このModはホスト(部屋主)のクライアントに導入するだけで動作し、他のクライアントのModの導入/未導入及び端末の種類に関係なく動作します。<br>
また、カスタムサーバーを利用したModと違い、URLやファイル編集などによるサーバー追加も不要なため、ホスト以外のプレイヤーはTown Of Hostを導入したホストの部屋に参加するだけで追加役職を楽しむことができます。<br>

しかし、公式の追加役職を置き換える仕組みで役職の追加を行っているため、以下の制限が発生することにご注意ください。<br>

- ホストが途中抜けをするなどの要因でホストが変更された場合、追加役職に関する処理が正常に動作しない可能性がある。
- 特殊役職を使用した場合、その特殊役職の設定を書き換える。(例 : ベントのクールダウンをなくすなど)

なお、ホスト以外のプレイヤーがこのModを導入した状態でプレイすると、以下のような変更が行われます。<br>

- 特殊役職独自の開始画面の表示
- 特殊役職の正常な勝利画面の表示
- 設定項目の追加
- その他

## Modの設定変更画面
待機ロビーでTabキーを押すと、部屋設定のテキストがTown Of Host専用の設定画面に変化します。<br>
操作方法は以下の通りです。<br>
| キー | 動作 |
| :---: | ---- |
| Tab | Modの設定画面の表示/非表示 |
| 十字キー上 | カーソルを上に移動 |
| 十字キー下 | カーソルを下に移動 |
| 十字キー右 | 選択中の項目を実行 |
| 十字キー左 | 一つ戻る |
| 数字キー | 数値を入力 |

※テンキーはサポートされていません。<br>

## 役職

### 役職対応表
| 追加役職名 | 判定 |
| ---- | ---- |
| Jester/ジェスター | クルーメイト |
| Madmate/マッドメイト | エンジニア |
| MadGuardian/マッドガーディアン | クルーメイト |
| MadSnitch/マッドスニッチ | クルーメイト |
| Bait/ベイト | クルーメイト |
| Terrorist/テロリスト | エンジニア |
| Mafia/マフィア | シェイプシフター |
| Vampire/ヴァンパイア | インポスター |
| SabotageMaster/サボタージュマスター | クルーメイト |
| Mayor/メイヤー | クルーメイト |
| Opportunist/オポチュニスト | クルーメイト |
| Snitch/スニッチ | クルーメイト |
| Sheriff/シェリフ | インポスター(ホストのみクルーメイト) |
| BountyHunter/バウンティーハンター | インポスター |

### Jester/ジェスター

陣営 : 第三<br>
判定 : クルーメイト<br>
勝利条件 : 投票で追放されること。<br>

投票で追放されたときに単独勝利となる第三陣営の役職です。<br>
追放されずにゲームが終了するか、キルされると敗北となります。<br>

### Madmate/マッドメイト

陣営 : インポスター<br>
判定 : エンジニア<br>

インポスター陣営に属しますが、マッドメイトからはインポスターが誰なのかはわかりません。<br>
インポスターからもマッドメイトが誰なのかはわかりません。<br>
キルやサボタージュはできませんが、通気口に入ることができます。<br>

(専用の設定があります。)<br>

### MadGuardian/マッドガーディアン

陣営 : インポスター<br>
判定 : クルーメイト<br>

インポスター陣営に属しますが、マッドガーディアンからはインポスターが誰なのかはわかりません。<br>
インポスターからもマッドガーディアンが誰なのかはわかりません。<br>
しかし、自身のタスクを全て完了させるとキルされなくなります。<br>
キルやサボタージュはできず、通気口に入ることもできません。<br>

(専用の設定があります。)<br>

### MadSnitch/マッドスニッチ

陣営 : インポスター<br>
判定 : クルーメイト<br>

インポスター陣営に属しますが、マッドスニッチからはインポスターが誰なのかはわかりません。<br>
インポスターからもマッドスニッチが誰なのかはわかりません。<br>
しかし、自身のタスクを全て完了させるとインポスターの名前が赤色に変化します。<br>
ベントに入れることができない代わりに、インポスターと視界の範囲が同じです。<br>

### Bait/ベイト

陣営 : クルーメイト<br>
判定 : クルーメイト<br>

キルされたときに、自分をキルした人に強制的に自分の死体を通報させることができます。<br>

### Terrorist/テロリスト

陣営 : 第三<br>
判定 : エンジニア<br>
勝利条件 : 全てのタスクを完了させた状態で死亡すること。<br>

自身のタスクを全て完了させた状態で死亡したときに単独勝利となる第三陣営の役職です。<br>
死因はキルと追放のどちらでもよいです。<br>
タスクを完了させずに死亡したり、死亡しないまま試合が終了すると敗北となります。<br>

### Mafia/マフィア

陣営 : インポスター<br>
判定 : シェイプシフター<br>

初期状態でベントやサボタージュ、変身は可能ですが、キルはできません。<br>
マフィアではないインポスターが全員死亡すると、マフィアもキルが可能となります。<br>
キルができない状態でもキルボタンはありますが、キルはできません。<br>
キルが可能になった後でも変身は継続して行うことができます。<br>

### Vampire/ヴァンパイア

陣営 : インポスター<br>
判定 : インポスター<br>

キルボタンを押してから一定秒数経って実際にキルが発生する役職です。<br>
キルをしたときのテレポートは発生しません。<br>
また、キルボタンを押してから設定された秒数が経つまでに会議が始まるとその瞬間にキルが発生します。<br>
しかし、ベイトをキルした場合のみ通常のキルとなり、強制的に通報させられます。<br>

(専用の設定があります。)<br>

### SabotageMaster/サボタージュマスター

陣営 : クルーメイト<br>
判定 : クルーメイト<br>

原子炉メルトダウンや酸素妨害、MIRA HQの通信妨害は片方を修理すれば両方が直ります。<br>
停電は1箇所のレバーに触れると全て直ります。<br>
PolusやThe Airshipのドアを開けるとその部屋の全てのドアが開きます。<br>

(専用の設定があります。)<br>

### Mayor/メイヤー

陣営 : クルーメイト<br>
判定 : クルーメイト<br>

票を複数持っており、まとめて一人またはスキップに入れることができます。<br>

(専用の設定があります。)<br>

### Opportunist/オポチュニスト

陣営 : 第三<br>
判定 : クルーメイト<br>
勝利条件 : いずれかの陣営が勝利したときに生き残っていること。<br>

ゲーム終了時に生き残っていれば追加勝利となる第三陣営の役職です。<br>
タスクはありません。<br>

### Snitch/スニッチ

陣営 : クルーメイト<br>
判定 : クルーメイト<br>

スニッチはタスクを完了させると人外の名前が赤色に変化します。<br>
しかし、スニッチのタスクが少なくなると人外からスニッチの名前が変わって見えてしまいます。<br>

### Sheriff/シェリフ

陣営 : クルーメイト<br>
判定 : インポスター(ホストのみクルーメイト)<br>

シェリフは人外をキルすることができます。<br>
しかし、クルーメイトをキルした場合、自身が死亡してしまいます。<br>
タスクはありません。<br>

(専用の設定があります。)

### BountyHunter/バウンティハンター

陣営 : インポスター<br>
判定 : インポスター<br>

バウンティーハンターが最初にキルをしようとした場合に、ターゲットが選ばれます。<br>
表示されたターゲットをキルすると次のキルクールが半分になります。<br>
ターゲットではない人をキルした場合でも、キルクールはそのまま維持されます。<br>

###　Warlock/ウォーロック

陣営 : インポスター<br>
判定 : シェイプシフター<br>

ウォーロックが変身する前にキルすると相手に呪いがかかります。<br>
そして次変身すると、呪った人に一番近い人が死にます。<br>
呪いがかかった人は次の会議でマークがつき、会議後に死にます。<br>

### SerialKiller\シリアルキラー

陣営 : インポスター<br>
判定 : シェイプシフター<br>

キルクールが短いインポスターです。<br>
その代わり、時間が来るまでにキルをしないと自爆してしまいます。<br>

## モード

### HideAndSeek/鬼ごっこモード

#クルーメイト陣営(青色)勝利条件<br>
全てのタスクを完了させること。<br>
※幽霊のタスクはカウントされません。<br>

#インポスター陣営(赤色)勝利条件<br>
全てのクルーメイトをキルすること。<br>
※クルーメイトとインポスターが同数であってもクルーメイトが全滅していないと試合は終わりません。<br>

#狐(紫色)勝利条件<br>
トロールを除くいずれかの陣営が勝利したときに生き残っていること。<br>

#トロール(緑色)勝利条件<br>
インポスターにキルされること。<br>

#禁止事項<br>
・サボタージュ<br>
・アドミン<br>
・カメラ<br>
・幽霊が生存者に位置情報を伝える行為<br>
・待ち伏せ(クルーメイトのタスク勝利が不可能となる可能性があるため。)<br>

#できないこと<br>
・死体の通報<br>
・緊急会議ボタン<br>
・サボタージュ<br>

(専用の設定があります。)<br>

### NoGameEnd/デバッグモード

#クルーメイト陣営勝利条件<br>
なし<br>

#インポスター陣営勝利条件<br>
なし<br>

#禁止事項<br>
なし<br>

#できないこと<br>
ホストのSHIFT+L+Enter以外でのゲーム終了。<br>

勝利判定が存在しないデバッグ用のモードです。<br>

### SyncButtonMode/ボタン回数同期モード

プレイヤー全員のボタン回数が同期されているモードです。<br>

(専用の設定があります。)<br>

## 参考など

ベイトやヴァンパイア、オポチュニストなどの役職とModの作成方法の参考 : https://github.com/Eisbison/TheOtherRoles<br>
ジェスター(てるてる)とマッドメイトの役職 : https://au.libhalt.net<br>
テロリスト(Trickstar + Joker) : https://github.com/MengTube/Foolers-Mod<br>

作者のTwitter : https://twitter.com/XenonBottle<br>
