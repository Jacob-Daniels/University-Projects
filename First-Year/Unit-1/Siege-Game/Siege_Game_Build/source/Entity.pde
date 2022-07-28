// parent class

abstract class Entity {
  // Attributes
  int x;
  int y;
  int size;
  int speed;

  // Constructor
  Entity(int x, int y, int size, int speed) {
    this.x = x;
    this.y = y;
    this.size = size;
    this.speed = speed;
  }

  // Methods
  void update() {
    render();
    move();
    collision();
  }

  abstract void render();

  abstract void move();

  abstract void collision();
}  // end of 'Character' class
