export class Task {
  static nextId: number = 1;

  constructor(
    public taskName: string,
    public status: boolean,
    public category: string,
    public id: number = 0
  ){
    this.id = id ? id : Task.nextId++;
  }
}
