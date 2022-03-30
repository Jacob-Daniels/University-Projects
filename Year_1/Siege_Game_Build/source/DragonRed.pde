// red dragon class

class DragonRed extends Enemy {
  // attributes
  final int point = 2;
  final int damage = 1;
  int fireballCooldown;
  int animationCounter;

  // constructor
  DragonRed(int x, int y, int size, int speed, int animationCounter, int fireballCooldown) {
    super(x, y, size, speed);
    this.animationCounter = animationCounter;
    this.fireballCooldown = fireballCooldown;
  }

  // methods
  void render() {
    // update animcation counter
    dragonCounter();
    // display enemy image
    animation.redDragonAnimation(x, y, animationCounter);
    // update fireball projectile
    enemyProjectile.checkFireball();
  }

  void dragonCounter() {
    // check values to increase or reset
    if (animationCounter < 40) {
      animationCounter++;
    } else {
      animationCounter = 0;
    }
  }
  void collision() {  // collision between other dragons
    for (DragonRed dragons : redDragonList) {
      if (checkOtherDragons(dragons) == true) {
        if (dragons.y > 1050) {  // reposition enemies if off screen
          dragons.y = int(random(1100, 1800));
          dragons.x = int(random(xLeftBorder, xRightBorder));
        }
      }
    }
  }

  boolean checkOtherDragons(DragonRed other) {  // checks collision between other dragons
    for (DragonGold dragons : goldDragonList) {
      if (other.boolCollisionEnemy(dragons) == true) {
        return true;
      }
    }
    for (DragonBlue dragons : blueDragonList) {
      if (other.boolCollisionEnemy(dragons) == true) {
        return true;
      }
    }
    return false;
  }
}  // end of class
