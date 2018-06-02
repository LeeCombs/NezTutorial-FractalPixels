using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace NezProject  {

    public class Game1 : Nez.Core {

        public Game1() {
            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize() {
            base.Initialize();
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
            GraphicsDevice.Clear(Color.LightGreen);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
