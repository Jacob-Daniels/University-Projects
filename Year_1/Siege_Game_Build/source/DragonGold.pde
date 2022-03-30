// gold dragon class

class DragonGold extends Enemy {
  // attributes
  final int point = 5;
  final int damage = 1;
  int animationCounter;

  // constructor 
  DragonGold(int x, int y, int size, int speed, int animationCounter) {
    super(x, y, size, speed);
    this.animationCounter = animationCounter;
  }
  // methods
  void render() {
    // update animation counter
    dragonCounter();
    // display enemy image
    animation.goldDragonAnimation(x, y, animationCounter);
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
    for (DragonGold dragons : goldDragonList) {
      if (checkOtherDragons(dragons) == true) {
        if (dragons.y > 1050) {  // reposition enemies if off screen
          dragons.y = int(random(1100, 1800));
          dragons.x = int(random(xLeftBorder, xRightBorder));
        }
      }
    }
  }

  boolean checkOtherDragons(DragonGold other) {  // checks collision between other dragons
    for (DragonRed dragons : redDragonList) {
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
