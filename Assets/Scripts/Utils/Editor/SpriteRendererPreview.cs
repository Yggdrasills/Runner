using UnityEditor;
using UnityEngine;

namespace AmayaCore.Utils.Editor
{
    [CustomPreview(typeof(SpriteRenderer))]
    public class SpriteRendererPreview : ObjectPreview
    {
        private Texture _sprite = null;

        private bool HasSprite()
        {
            var spriteRenderer = (target as SpriteRenderer).GetComponent<SpriteRenderer>();

            if (spriteRenderer.sprite != null)
            {
                _sprite = AssetPreview.GetAssetPreview(spriteRenderer.sprite);
                return true;
            }

            return false;
        }

        public override bool HasPreviewGUI()
        {
            return HasSprite();
        }

        public override void OnPreviewGUI(Rect r, GUIStyle background)
        {
            if (_sprite == null) return;
            EditorGUI.DrawTextureTransparent(r, _sprite, ScaleMode.ScaleToFit);
        }
    }

}