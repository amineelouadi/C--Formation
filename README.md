# Projet CSharp11 à CSharp14

Ce projet démontre les nouvelles fonctionnalités et améliorations introduites dans les versions C# 11 à C# 14. Chaque fichier contient des exemples de code illustrant des concepts spécifiques.

## Structure du Projet

Le projet est organisé en plusieurs dossiers, chacun contenant des fichiers qui démontrent des fonctionnalités spécifiques de C#. Voici un aperçu des dossiers et de leur contenu :

### CSharp11

- **Features**
  - **GenericMath.cs**: Montre l'utilisation des mathématiques génériques avec des types numériques.
  - **ListPatterns.cs**: Démonstration des motifs de liste pour la correspondance de tableaux.
  - **RawStringLiterals.cs**: Utilisation de littéraux de chaîne bruts pour des chaînes multi-lignes.
  - **SpanPatternMatching.cs**: Correspondance de motifs avec `ReadOnlySpan`.
  
- **Models**
  - **Person.cs**: Classe représentant une personne avec des propriétés requises.
  - **Point.cs**: Structure représentant un point en 2D.

- **Attributes**
  - **GenericAttribute.cs**: Attribut générique pouvant être appliqué à des classes.

### CSharp12

- **Attributes**
  - **ExperimentalAttribute.cs**: Démonstration de l'utilisation d'attributs expérimentaux.
  
- **Features**
  - **CollectionExpressions.cs**: Syntaxe d'expression de collection pour créer des tableaux et des listes.
  - **InlineArrays.cs**: Utilisation de tableaux en ligne.
  - **LambdaParameters.cs**: Démonstration des paramètres de lambda avec des valeurs par défaut.
  - **PrimaryConstructors.cs**: Utilisation de constructeurs principaux pour initialiser des propriétés.
  - **RefReadOnlyParameters.cs**: Utilisation de paramètres en lecture seule par référence.

### CSharp13

- **Features**
  - **EscapeSequence.cs**: Démonstration des séquences d'échappement ANSI.
  - **ImplicitIndexerInitializers.cs**: Utilisation d'initialisateurs d'indexeurs implicites.
  - **LockSemantics.cs**: Nouvelles sémantiques de verrouillage.
  - **MethodGroupNaturalType.cs**: Assignation de groupes de méthodes à des actions.
  - **OverloadResolution.cs**: Résolution de surcharge avec des attributs.
  - **ParamsCollections.cs**: Traitement d'éléments en tant que paramètres.
  - **PartialProperties.cs**: Propriétés partielles avec des implémentations séparées.
  - **RefLocalsInIterators.cs**: Utilisation de références locales dans les itérateurs.
  - **RefStructGenerics.cs**: Traitement de structures de référence avec des génériques.
  - **RefStructInterfaces.cs**: Interfaces pour les structures de référence.

### CSharp14

- **Features**
  - **FieldBackedProperties.cs**: Propriétés soutenues par des champs avec validation.
  - **LambdaModifiers.cs**: Modificateurs de lambda pour passer des paramètres par référence.
  - **NameOfUnboundGenerics.cs**: Utilisation de `nameof` avec des génériques non liés.
  - **PartialEventsConstructors.cs**: Événements et constructeurs partiels.
  - **SpanConversions.cs**: Conversions de `Span` et traitement de données.
  
- **Models**
  - **DataEntity.cs**: Classe partielle représentant une entité de données avec des propriétés soutenues par des champs.

## Comment Exécuter le Projet

Pour exécuter le projet, assurez-vous d'avoir installé .NET SDK. Ensuite, vous pouvez ouvrir le projet dans votre IDE préféré (comme Visual Studio ou Visual Studio Code) et exécuter les méthodes de démonstration dans chaque classe.

## Conclusion

Ce projet illustre les nouvelles fonctionnalités de C# et comment elles peuvent être utilisées pour écrire un code plus propre et plus efficace. N'hésitez pas à explorer chaque fichier pour voir des exemples pratiques de ces fonctionnalités.
