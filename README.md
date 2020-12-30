# VertexAnimationTextureUnityShaderGraph
テクスチャにベイクした頂点アニメーションを実行するシェーダーサンプルです。  
ShaderGraphで使用する事ができます。  
**実装途中(WIP)です**

## Material設定
- VertexAnimationTexture  
Mayaツールで作成した頂点アニメーションテクスチャをセットします。
- Detail  
Mayaツールで設定したDetailを入力してください。

## テクスチャ設定
- sRGB (Color Texture) : Off  
- Non-Power of 2 : None  
- Generate Mip Maps : Off  
- FilterNode : Point(no filter)
- Format : RGBA 32 bit

## 注意

頂点番号はUV2から取得しています。
Tools→Open SetVertexIdToUV2にて格納処理を行ってください。
(ShaderGraphではVertexIdを取得できない?)

テクスチャサイズはプロパティとして設定しています。
(Texel Size NodeがVertexPositionに接続できない?)