//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts : Entitas.IContexts {

    public static Contexts sharedInstance {
        get {
            if (_sharedInstance == null) {
                _sharedInstance = new Contexts();
            }

            return _sharedInstance;
        }
        set { _sharedInstance = value; }
    }

    static Contexts _sharedInstance;

    public ConfigContext config { get; set; }
    public GameContext game { get; set; }
    public GameStateContext gameState { get; set; }
    public InputContext input { get; set; }

    public Entitas.IContext[] allContexts { get { return new Entitas.IContext [] { config, game, gameState, input }; } }

    public Contexts() {
        config = new ConfigContext();
        game = new GameContext();
        gameState = new GameStateContext();
        input = new InputContext();

        var postConstructors = System.Linq.Enumerable.Where(
            GetType().GetMethods(),
            method => System.Attribute.IsDefined(method, typeof(Entitas.CodeGeneration.Attributes.PostConstructorAttribute))
        );

        foreach (var postConstructor in postConstructors) {
            postConstructor.Invoke(this, null);
        }
    }

    public void Reset() {
        var contexts = allContexts;
        for (int i = 0; i < contexts.Length; i++) {
            contexts[i].Reset();
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EntityIndexGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

    public const string EnemyId = "EnemyId";

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeEntityIndices() {
        game.AddEntityIndex(new Entitas.EntityIndex<GameEntity, int>(
            EnemyId,
            game.GetGroup(GameMatcher.EnemyId),
            (e, c) => ((EnemyIdComponent)c).Value));
    }
}

public static class ContextsExtensions {

    public static System.Collections.Generic.HashSet<GameEntity> GetEntitiesWithEnemyId(this GameContext context, int Value) {
        return ((Entitas.EntityIndex<GameEntity, int>)context.GetEntityIndex(Contexts.EnemyId)).GetEntities(Value);
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.VisualDebugging.CodeGeneration.Plugins.ContextObserverGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Contexts {

#if (!ENTITAS_DISABLE_VISUAL_DEBUGGING && UNITY_EDITOR)

    [Entitas.CodeGeneration.Attributes.PostConstructor]
    public void InitializeContextObservers() {
        try {
            CreateContextObserver(config);
            CreateContextObserver(game);
            CreateContextObserver(gameState);
            CreateContextObserver(input);
        } catch(System.Exception e) {
            UnityEngine.Debug.LogError(e);
        }
    }

    public void CreateContextObserver(Entitas.IContext context) {
        if (UnityEngine.Application.isPlaying) {
            var observer = new Entitas.VisualDebugging.Unity.ContextObserver(context);
            UnityEngine.Object.DontDestroyOnLoad(observer.gameObject);
        }
    }

#endif
}
