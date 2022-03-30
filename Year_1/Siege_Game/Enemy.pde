// Enemy class

class Enemy extends Entity {
  // Attributes
  final int xLeftBorder = 75;
  final int xRightBorder = 1125;  // 1080
  final int redMinType = 18;
  final int goldMinType = 28;
  int dragonType;

  // Constructor
  Enemy(int x, int y, int size, int speed) {
    super(x, y, size, speed);
  }

  // Methods
  void render() {
    // children of 'Enemy' class render own images
  }

  void move() {
    // check enemy is on screen to move
    if (this.y > -size/2) {
      this.y -= speed;
    } else {
      if (this instanceof DragonBlue) {
        // delete current enemy
        blueDragonList.remove(this);
        // create a new random enemy
        enemy.createEnemy();
      } else if (this instanceof DragonRed) {
        // delete current enemy
        redDragonList.remove(this);
        // create a new random enemy
        enemy.createEnemy();
      } else if (this instanceof DragonGold) {
        // delete current enemy
        goldDragonList.remove(this);
        // create a new random enemy
        enemy.createEnemy();
      }
    }
  }

  void createEnemy() {  // declare new enemy
    // create enemies for child classes
    dragonType = int(random(0, 30));
    // create object depending on dragon type
    if (dragonType >= 0 && dragonType < redMinType) {  // blue dragon
      blueDragon = new DragonBlue(int(random(120, 1080)), int(random(1100, 1500)), 150, 5, int(random(0, 40)));
      blueDragonList.add(blueDragon);
    } else if (dragonType >= redMinType && dragonType < goldMinType) {  // red dragon
      redDragon = new DragonRed(int(random(120, 1080)), int(random(1100, 1500)), 150, 4, int(random(0, 40)), int(random(1, 400)));
      redDragonList.add(redDragon);
    } else if (dragonType >= goldMinType && dragonType < 30) {  // gold dragon
      goldDragon = new DragonGold(int(random(120, 1080)), int(random(1100, 1500)), 150, 4, int(random(0, 40)));
      goldDragonList.add(goldDragon);
    }
  }

  void collision() {
    // children of 'Enemy' class check collision
  }

  boolean boolCollisionEnemy(Entity other) {  // detecting collision between enemies
    if (dist(other.x, other.y, this.x, this.y) < (this.size + 10)) {
      return true;
    } else {
      return false;
    }
  }
}  // end of 'Enemy' class
