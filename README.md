# Unity-Developer-Test-Assignment

Scenes:
1. StartMenu.unity
   - Title, background image
   - Fade-in effect via CanvasGroup (FadeIn.cs)
   - "Play" -- loads Gameplay scene
   - "Quit" -- exits app

2. Gameplay.unity
   - Player can move left/right and jump (PlayerController.cs)
   - Collectibles rotate and disappear on collection (Collectible.cs)
   - Score counter updates in UI (GameManager.cs)
   - Unique Feature: Player changes color to red when jumping, smoothly returning to original.
     Implemented using SpriteRenderer and Color.Lerp() for smooth transition.

Used Unity Components:
- Rigidbody2D, BoxCollider2D, CircleCollider2D for physics
- Canvas, Text (UI) for score and menu
- SceneManager for scene transitions
- CanvasGroup for fade-in
