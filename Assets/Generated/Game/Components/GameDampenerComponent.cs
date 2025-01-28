//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DampenerComponent dampener { get { return (DampenerComponent)GetComponent(GameComponentsLookup.Dampener); } }
    public bool hasDampener { get { return HasComponent(GameComponentsLookup.Dampener); } }

    public void AddDampener(float newValue) {
        var index = GameComponentsLookup.Dampener;
        var component = (DampenerComponent)CreateComponent(index, typeof(DampenerComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDampener(float newValue) {
        var index = GameComponentsLookup.Dampener;
        var component = (DampenerComponent)CreateComponent(index, typeof(DampenerComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDampener() {
        RemoveComponent(GameComponentsLookup.Dampener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDampener;

    public static Entitas.IMatcher<GameEntity> Dampener {
        get {
            if (_matcherDampener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Dampener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDampener = matcher;
            }

            return _matcherDampener;
        }
    }
}
