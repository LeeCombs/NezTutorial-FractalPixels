using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.Sprites;
using Nez.Tiled;

namespace NezProject  {

    public class Game1 : Core {
        
        // For managing the order we want layers to be rendered. Higher numbers mean lower layers.
        enum RenderLayer {
            AboveDetailShadow = -2,
            AboveDetail = -1,
            Player = 1,
            TileMap = 10
        }

        public Game1() {
            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize() {
            base.Initialize();

            // Create our custom scene
            Scene myScene = Scene.createWithDefaultRenderer(Color.LightGreen);

            // Load the Tiled map, and render it below everything
            var tiledMap = myScene.content.Load<TiledMap>("maps/Map_1");
            var tiledEntity = myScene.createEntity("tiled-map");
            var tiledMapComponent = tiledEntity.addComponent(new TiledMapComponent(tiledMap, "Collision"));
            tiledMapComponent.setLayersToRender(new string[] { "Above_Detail", "Detail", "Tile", "Background" });
            tiledMapComponent.renderLayer = (int)RenderLayer.TileMap;

            // Set the scene so Nez can take over
            scene = myScene;
        }
        
        protected override void LoadContent() {
            // TODO: use this.Content to load your game content here
        }
        
        protected override void UnloadContent() {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
