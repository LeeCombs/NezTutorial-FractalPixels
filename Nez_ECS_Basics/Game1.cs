using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.Sprites;

namespace NezProject  {

    public class Game1 : Core {

        public Game1() {
            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize() {
            base.Initialize();

            // Create our custom scene
            Scene myScene = Scene.createWithDefaultRenderer(Color.LightGreen);

            // Create the Player entity
            Entity playerEntity = myScene.createEntity("player");
            Texture2D playerTexture = myScene.content.Load<Texture2D>("images/playerTexture");
            playerEntity.addComponent(new Sprite(playerTexture));
            playerEntity.position = new Vector2(50, 50);

            // Create the Enemy entity
            Entity enemyEntity = myScene.createEntity("enemy");
            Texture2D enemyTexture = myScene.content.Load<Texture2D>("images/enemyTexture");
            enemyEntity.addComponent(new Sprite(enemyTexture));
            enemyEntity.position = new Vector2(150, 50);
            enemyEntity.addComponent(new HealthComponent());
            
            // Add the entity processor for health components
            myScene.addEntityProcessor(new HealthSystem(new Matcher().all(typeof(HealthComponent))));

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
