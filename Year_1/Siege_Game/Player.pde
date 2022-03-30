// Player class

class Player extends Entity {
  // Attributes
  boolean moveLeft = false;
  boolean moveRight = false;
  int playerLife = 3;
  int score = 0;
  int reloadTimer = 0;

  // Constructor
  Player(int x, int y, int size, int speed) {
    super(x, y, size, speed);
  }

  // Methods
  void render() {  // rendering the player
    reloadTimer();
    // update animation counter
    animation.updatePlayerCounter();
    // update image
    animation.playerAnimation(x, y);
  }

  void reloadTimer() {  // decrease timer value
    // reload timer
    if (player.reloadTimer > 0) {
      player.reloadTimer -= 1;
    }
  }

  void move() {  // moving the player if they are within range
    if (moveLeft == true) {
      if (this.x > 75) {  // left border
        x -= speed;
      }
    }
    if (moveRight == true) {
      if (this.x < width - 75) {  // right border
        x += speed;
      }
    }
  }

  void playerScore(int point) {  // update score
    score += point;
  }

  void playerHealth(int damage) {  //  update health
    // remove a life
    playerLife -= damage;
    // check if player died
    if (player.playerLife == 0) {
      display.gameMode = 4;
    }
  }

  void collision() {  // check collision between player and dragons
    for (int i = 0; i < blueDragonList.size(); i++) {  // blue dragon
      if (this.boolCollisionPlayer(blueDragonList.get(i)) == true) {  // if enemy hits player
        // remove and create a new enemy
        blueDragonList.remove(blueDragonList.get(i));
        enemy.createEnemy();
        // remove player life
        playerHealth(blueDragon.damage);
      }
    }
    for (int i = 0; i < redDragonList.size(); i++) {  // red dragon
      if (this.boolCollisionPlayer(redDragonList.get(i)) == true) {  // if enemy hits player
        // remove and create new enemy
        redDragonList.remove(redDragonList.get(i));
        enemy.createEnemy();
        // remove player life
        playerHealth(redDragon.damage);
      }
    }
    for (int i = 0; i < goldDragonList.size(); i++) {  // gold dragon
      if (this.boolCollisionPlayer(goldDragonList.get(i)) == true) {  // if enemy hits player
        // remove and create new enemy
        goldDragonList.remove(goldDragonList.get(i));
        enemy.createEnemy();
        // remove player life
        playerHealth(goldDragon.damage);
      }
    }
  }

  // returns true if collision occurs
  boolean boolCollisionPlayer(Entity other) {  // detecting collision between player and enemy
    if (dist(other.x, other.y, this.x, this.y) < (other.size/2 + player.size/2)) {
      // add position of enemy to deathList
      deathAnimation = new DeathAnimation(other.x, other.y, 115);
      deathList.add(deathAnimation);
      return true;
    } else {
      return false;
    }
  }
}  // end of 'Player' class
