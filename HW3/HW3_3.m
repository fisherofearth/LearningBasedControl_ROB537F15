alpha = 0.5;
gamma = 1;
stepLimit = 20;
mapSize = [10; 5]; 
goalS = [10;4];
rtf = [1;0];
upf = [0;1];
ltf = [-1;0];   
dnf = [0;-1];
A = [rtf upf ltf dnf];
X = 1;
Y = 2;

Q = ones(mapSize(X), mapSize(Y), 4) * 1; % initial Q table (xD, yD, actionD)
initialS = [randi(10);randi(5)]; % initital state [x; y]
rec_step = [];
for learn = 1 : 100
    S = initialS;
    R = 0;
    for step = 1: stepLimit
        
        prob_action = [Q(S(X),S(Y),1); Q(S(X),S(Y),2); Q(S(X),S(Y),3); Q(S(X),S(Y),4)]; % construct action probability vector     
        verify = -1;
        while(verify<0)
            a = PickAction(prob_action, 1); % Pick an action based on the probability of actions
            verify = Constrain( S, A(:,a), mapSize ); % verify if state+action is illegal(in-map)
            prob_action(a) = 0; %remove this action because it is illegal
        end
        newS = S + A(:,a);
        
        if(goalS == newS)
            R = R + 100;
            break;
        else
            R = R - 1;
        end

        % Update Q table
         prob_action = [
             Q(newS(X),newS(Y),1);
             Q(newS(X),newS(Y),2);
             Q(newS(X),newS(Y),3);
             Q(newS(X),newS(Y),4)]; % construct action probability vector     
        verify = -1;
        while(verify<0)
            [maxV aOp] = max(prob_action); % same values ???
            verify = Constrain( newS, A(:,aOp), mapSize ); % verify if state+action is illegal(in-map) 
            prob_action(aOp) = 0; %remove this action because it is illegal
        end

        Q(S(X),S(Y),a) = Q(S(X),S(Y),a) + alpha * (Reward(S) + (gamma*Q(newS(X),newS(Y),aOp)) - Q(S(X),S(Y),a));

        S = newS; % update current state
    end
    rec_step(learn) = R;
end


%% NOTE:
% function randi(n) -> a integer in 1:n

%a - action = {1 2 3 4} = {right up left down}




