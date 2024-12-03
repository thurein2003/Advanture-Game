Game Name: Patrol Enemy 
Overview
This project is a simple Unity-based 2D game where the player can interact with an enemy that patrols a platform. The enemy uses animations to walk and attack the player, with the ability to be hurt. The project demonstrates basic AI behaviors for a patrol enemy.

Features
Patrolling AI: The enemy moves back and forth along a designated path.
Attack Animations: The enemy has two attack animations (EnemyPatrol Attack 1 and EnemyPatrol Attack 2).
Damage Handling: The enemy has a hurt animation triggered when hit.
Basic Physics: The enemy uses a RigidBody2D for movement physics and BoxCollider2D for collision detection.
Requirements
Unity 2020.3 or higher
Basic understanding of Unity's Animator system and physics components
Installation
Clone the repository to your local machine:
bash
Copy code
git clone https://github.com/your-username/your-repo-name.git
Open the project in Unity by double-clicking the .unity file.
Ensure all assets are imported and dependencies are resolved.
Setup Instructions
PatrolEnemy GameObject: The patrol enemy has a PatrolEnemy script that controls its movement and interactions.
Animator Controller: The Animator component is set up with the EnemyPatrol Walk, EnemyPatrol Attack 1, EnemyPatrol Attack 2, and EnemyPatrol Hurt animations.
Player Interaction: The player character should be able to trigger the enemy's attack or hurt animation based on interactions (implement player logic accordingly).
How to Play
Launch the scene in Unity's Play Mode.
The patrol enemy will automatically start patrolling across the platform.
If the player character interacts with the enemy, the enemy will attack or react based on the player's actions.
Contributions
Feel free to fork the project and submit pull requests. You can also report any bugs or issues in the issue tracker.
