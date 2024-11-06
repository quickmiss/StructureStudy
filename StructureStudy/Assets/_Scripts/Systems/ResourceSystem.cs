using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// One repository for all scriptable objects. Create your query methods here to keep your business logic clean.
/// I make this a MonoBehaviour as sometimes I add some debug/development references in the editor.
/// If you don't feel free to make this a standard class
/// </summary>
public class ResourceSystem : StaticInstance<ResourceSystem> {
    public List<ScriptableExampleHero> ExampleHeroes { get; private set; }
    private Dictionary<ExampleHeroType, ScriptableExampleHero> _ExampleHeroesDict;

    protected override void Awake() {
        base.Awake();
        AssembleResources();
    }

    private void AssembleResources() {
        ExampleHeroes = Resources.LoadAll<ScriptableExampleHero>("ExampleHeroes").ToList(); // Assets/Resource/ExampleHeroes/<ScriptableExamleHero>의 데이터 전부를 ExampleHeroes리스트에 할당한다.
        _ExampleHeroesDict = ExampleHeroes.ToDictionary(r => r.HeroType, r => r);
    }

    public ScriptableExampleHero GetExampleHero(ExampleHeroType t) => _ExampleHeroesDict[t];
    public ScriptableExampleHero GetRandomHero() => ExampleHeroes[Random.Range(0, ExampleHeroes.Count)];
}   