// enemy projectile

class EnemyProjectile extends Entity {
  // attributes
  boolean removeProjectile = false;

  // constructor
  EnemyProjectile(int x, int y, int size, int speed, boolean removeProjectile) {
    super(x, y, size, speed);
    this.removeProjectile = removeProjectile;
  }

  // methods
  void render() {
    // update fireball animation counter
    animation.updateFireballCounter();
    // display new fireball images
    animation.fireballAnimation(x, y, size);
  }

  void checkFireball() {  // check if a fireball should be created
    for (int i=0; i < redDragonList.size(); i++) {
      if (redDragonList.get(i).y < 1000 && redDragonList.get(i).y > 200) {  // if in range to shoot
        if (redDragonList.get(i).fireballCooldown == 0) {  // set active if cooldown is 0
          if (redDragonList.get(i).y > 400) {  // check if new fireball should be created
            enemyProjectile.createFireball(redDragonList.get(i).x, redDragonList.get(i).y);
          }
          redDragonList.get(i).fireballCooldown = 1000;  // new timer for fireball
        } else {
          if (redDragonList.get(i).fireballCooldown > 0) {  // reduce cooldown if not 0
            redDragonList.get(i).fireballCooldown--;
          }
        }
      }
    }
  }

  void move() {
    if (this.y < 0) {
      fireballList.get(fireballList.indexOf(this)).removeProjectile = true;
    } else {
      this.y -= speed;
    }
  }

  void createFireball(int x, int y) {  // declare a new fireball
    enemyProjectile = new EnemyProjectile(x, y-50, 75, 10, false);
    fireballList.add(enemyProjectile);
  }

  void collision() {  // check for collisions between player and enemy projectile
    if (this.boolCollisionFireball(player) == true) {  // if fireball hits player
      // remove enemy and life when hit
      fireballList.remove(this);
      player.playerHealth(redDragon.damage);
    }
  }

  // returns true if collision occurs
  boolean boolCollisionFireball(Entity other) {  // detecting collision between player and fireball
    if (dist(other.x, other.y, this.x, this.y) < other.size + 9) {
      return true;
    } else {
      return false;
    }
  }
}  // end of 'EnemyProjectile' class
