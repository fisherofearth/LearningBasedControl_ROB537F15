

%% Task 1

alpha = 0.2;
episode = 2000;
V0 = ones(5,1) * 1;

rec_R = zeros(episode,4);
rec_R_Smoothed = zeros(episode,4);
rec_R_Cumul = zeros(episode,4);

steps = [20 20 100 100];
epsilon = [0 0.1 0 0.1];

for i = 1 :4
    [ V , rec_R(:,i)] = Task1(V0, steps(i), epsilon(i), alpha, episode);
    
end

for i = 1 :4
    rec_R_Smoothed(:,i) = smooth(rec_R(:,i),100);
    for e = 2 : episode
        rec_R_Cumul(e,i) = rec_R_Cumul(e-1,i) + rec_R(e-1,i);
    end
end

close all
plot(rec_R_Cumul(1:1500,:),'LineWidth',2);
title('Cumulative reward');
legend('20-step,greedy','20-step,e-greedy 0.1','100-step,greedy','100-step,e-greedy 0.1');
ylabel('Accumulated reward');
xlabel('episode');

figure 
plot(rec_R_Smoothed(1:1500,:),'LineWidth',2)
title('Average reward');
legend('20-step,greedy','20-step,e-greedy 0.1','100-step,greedy','100-step,e-greedy 0.1');
ylabel('Average reward');
xlabel('episode');

figure 
boxplot(rec_R)



%% Task 2
alpha = 0.3;
epsilon =0.1;
episode =5000;
rec = zeros(episode,1);
rec_CR = zeros(episode,1);
[ V,rec ] = Task2(epsilon, alpha, episode );

close all
% for i = 1 : 5
% %     V(:,:,i) = V(:,:,i)/norm(V(:,:,i),1)
%     figure 
%     imagesc(V(:,:,i))
% end
for e = 2 : episode
    rec_CR(e,1) = rec_CR(e-1,1) + rec(e-1,1);
end
plot(rec_CR,'LineWidth',2);
ylabel('Accumulated reward');
xlabel('episode');
title('Cumulative reward');


%% Task 3
alpha = 0.3;
epsilon =0.1;
episode =5000;

rec_Q = zeros(episode,1);
rec_Q2 = zeros(episode,1);
rec_CR_Q = zeros(episode,1);

gamma = 0.5;
[ Q,rec_Q ] = Task3(epsilon, alpha, gamma,episode );
gamma = 0.8;
[ Q,rec_Q2 ] = Task3(epsilon, alpha, gamma,episode );

% close all
% for i = 1 : 5
% %     V(:,:,i) = V(:,:,i)/norm(V(:,:,i),1)
%     figure 
%     imagesc(Q(:,:,i))
% end

close all
figure

for e = 2 : episode
    rec_CR_Q(e,1) = rec_CR_Q(e-1,1) + rec_Q(e-1,1);
end

plotdata = [rec_CR, rec_CR_Q];
for e = 2 : episode
    rec_CR_Q(e,1) = rec_CR_Q(e-1,1) + rec_Q2(e-1,1);
end
plotdata(:,3) = rec_CR_Q;


plot(plotdata,'LineWidth',2);
title('Cumulative reward');
legend('action-value','Q-learning,Gamma =0.5','Q-learning,Gamma =0.8');
ylabel('Accumulated reward');
xlabel('episode');

%% NOTE:
% function randi(n) -> a integer in 1:n

%a - action = {1 2 3 4} = {right up left down}
% 
% tou =0.5;
% V = [0.1 0.4 0 0.05]
% exp(V/tou)/sum(exp(V/tou))
% 
% 
% Y = normpdf(1,0,1)
% 
% mu = 1
% sigma = 5
% 
% for i = 1 : 1000
% R(i) = normrnd(mu,sigma);
% end
% plot(R)
% 
% y = pdf('Normal',R,mu,sigma)


