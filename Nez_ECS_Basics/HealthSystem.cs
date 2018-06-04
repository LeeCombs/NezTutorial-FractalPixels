using Nez;

namespace NezProject {
    class HealthSystem : EntityProcessingSystem {
        public HealthSystem(Matcher matcher) : base(matcher) { }

        public override void process(Entity entity) {
            // Grab the component from the entity
            var healthComponent = entity.getComponent<HealthComponent>();

            // Tick down the health
            healthComponent.health--;

            // Destory the entity once it runs out of health
            if (healthComponent.health <= 0)
                entity.destroy();
        }
    }
}
