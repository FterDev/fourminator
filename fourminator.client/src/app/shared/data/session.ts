import User from "./user";

export default interface Session
{
  user: User;
  remember: boolean;
}
